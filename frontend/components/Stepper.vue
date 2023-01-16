<template>
  <n-space class="steps-container" vertical justify="start">
    <div class="wrapper">
      <ol class="stepper">
        <template v-for="(step, index) in this.steps">
          <li class="stepper__item">
            <a @click="currentStep=index">
              <h3 class="stepper__title">{{ step.title }}</h3>
              <p class="stepper__desc">{{ step.description }}</p>
            </a>
          </li>
        </template>
      </ol>
    </div>

    <!-- Steps content -->
    <component :is="steps[currentStep].component" v-model="currentStep" @userTypeSelected="onUserTypeSelected"
               ref="stepRef"></component>

    <!-- Steps controls -->
    <n-space class="stepper-controls" justify="end">
      <n-button quaternary strong size="large" @click="onPreviousButtonClick" v-if="this.currentStep !== 0">
        Terug
      </n-button>
      <n-button secondary strong class="stepper__next-button" size="large" @click="onNextButtonClick"
                v-if="this.currentStep < this.steps.length -1">
        Volgende stap
      </n-button>
      <n-button secondary strong class="stepper__next-button" size="large" @click="onCompleteButtonClick"
                :loading="isSubmitting"
                v-if="this.currentStep === this.steps.length -1">
        Voltooien
      </n-button>
    </n-space>
  </n-space>
</template>

<script>
import Step1 from "./SignUpStep1";
import Step2 from "./SignUpStep2";
import Step3 from "./SignUpStep2Internship";
import Step4 from "./SignUpInternshipCompanyContactPerson";
import {NButton, NSpace, useMessage} from "naive-ui"
import {postNewCompany, postNewUser} from "../services/UserService";
import {ref} from "vue";

const studentSteps = [
  {
    title: "Stap 1",
    description: "Account type",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 2",
    description: "Persoonlijke informatie",
    component: "step2",
    required: true,
    userType: "student"
  }
];

const internshipSteps = [
  {
    title: "Stap 1",
    description: "Account type",
    component: "Step1",
    required: true,
  },
  {
    title: "Stap 2",
    description: "Bedrijfsinformatie",
    component: "Step3",
    required: true,
    userType: "internshipCompany"
  },
];
const isSubmitting = ref(false)

let studentData = {
  firstName: '',
  lastName: '',
  email: '',
  password: '',
}

let internshipCompanyData = {
  email: '',
  password: '',
  name: '',
  kvk: ''
}

export default {
  components: {Step1, Step2, Step3, Step4, NButton, NSpace},
  methods: {
    onUserTypeSelected(value) {
      this.userType = value
      if (value === "internshipCompany") {
        this.steps = internshipSteps
      } else if (value === "student") {
        this.steps = studentSteps
      }
    },
    validateCurrentStep() {
      return this.$refs.stepRef.handleValidateClick()
    },
    assignFormValues(formValues) {
      if (this.userType === 'student') {
        Object.keys(formValues).forEach(function (key) {
          if (key in studentData) {
            studentData[key] = formValues[key];
          }
        });
      }
      if (this.userType === 'internshipCompany') {
        Object.keys(formValues).forEach(function (key) {
          if (key in internshipCompanyData) {
            internshipCompanyData[key] = formValues[key];
          }
        });
      }
    },
    onPreviousButtonClick() {
      if (this.currentStep > 0) {
        this.currentStep--
      }
    },
    onNextButtonClick() {
      this.validateCurrentStep()
          .then((formValues) => {
            this.assignFormValues(formValues)
            if (this.currentStep < this.steps.length - 1) {
              this.currentStep++
            }
          })
          .catch((val) => {
            console.log(val)
          })
    },
    async onCompleteButtonClick() {
      isSubmitting.value = true
      if (this.userType === 'student') {
        this.validateCurrentStep()
            .then((formValues) => {
              this.assignFormValues(formValues)
              console.log(studentData)
              postNewUser(studentData).then(() => {
                console.log('New user created')
                this.message.success('New user created')
              })
                  .catch(error => {
                    console.log(error)
                    this.message.error(error.message)
                  })
            })
            .catch((val) => {
              console.log(val)
            })
      }
      if(this.userType === 'internshipCompany') {
        this.validateCurrentStep()
            .then((formValues) => {
              this.assignFormValues(formValues)
              console.log(internshipCompanyData)
              postNewCompany(internshipCompanyData).then(() => {
                console.log('New company created')
                this.message.success('New company created')
              })
            })
        isSubmitting.value = false
      }
    },
  },

  data() {
    return {
      message: useMessage(),
      currentStep: 0,
      steps: studentSteps,
      userType: "student",
      isSubmitting,
    }
  }
}
</script>

<style scoped>
.stepper {
  --circle-size: clamp(1.5rem, 5vw, 3rem);
  --spacing: clamp(0.25rem, 2vw, 0.5rem);
}

.stepper {
  display: flex;
}

.stepper-controls {
  margin-top: 25px;
}

.stepper__item {
  display: flex;
  flex-direction: column;
  flex: 1;
  text-align: center;
}

.stepper__item a {
  cursor: pointer;
}

.stepper__item:before {
  --size: 3rem;
  content: "";
  display: block;
  width: var(--circle-size);
  height: var(--circle-size);
  border-radius: 50%;
  background-color: var(--color-primary);
  margin: 0 auto 1rem;
}

.stepper__item:not(:last-child):after {
  content: "";
  position: relative;
  top: calc(var(--circle-size) / 2);
  width: calc(100% - var(--circle-size) - calc(var(--spacing) * 2));
  left: calc(50% + calc(var(--circle-size) / 2 + var(--spacing)));
  height: 2px;
  background-color: #e0e0e0;
  order: -1;
}

.stepper__title {
  font-weight: bold;
  font-size: clamp(1rem, 4vw, 1.25rem);
  margin-bottom: 0.5rem;
}

.stepper__desc {
  color: grey;
  font-size: clamp(0.85rem, 2vw, 1rem);
  padding-left: var(--spacing);
  padding-right: var(--spacing);
}

.wrapper {
  max-width: 1000px;
  margin: 2rem auto 0;
}

.steps-container {
  width: 100%;
  margin: 0 auto;
}

.stepper__next-button {
  background: var(--color-primary);
  border: none;
}

@media (min-width: 640px) {
  .steps-container {
    max-width: 550px;
  }
}

</style>
