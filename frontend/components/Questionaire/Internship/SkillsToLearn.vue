<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Welke vaardigheden kan de student tijdens de stage leren?</h1>
    <p class="questionnaire-heading__subtitle">(Max. {{maxSelectedItems}} keuzes)</p>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules" class="questionnaire-grid">
      <n-form-item class="questionnaire-card__container" v-for="(skill, key, index) in questionnaire.skills" :key="key">
        <QuestionnaireItemCard :skill="skill" size="small" ref="itemRefs" @click="onQuestionnaireItemCardClick(key, index)"/>
      </n-form-item>
      <div class="questionnaire-description">
        <h3 class="questionnaire-description__header">Beschrijf de vaardigheden</h3>
        <n-form-item class="questionnaire-description__field" path="skillsToLearnDescription">
          <n-input
              v-model:value="formValue.skillsToLearnDescription"
              placeholder="Geef een omschrijving."
              type="textarea"
          />
        </n-form-item>
      </div>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NFormItem, NInput, NRadioGroup, NRadio, NButton, FormInst, FormRules, useMessage} from 'naive-ui'
import {defineComponent, ref} from "vue";
import questionnaireData from '../../../assets/json/questionaire.json'
import QuestionnaireItemCard from "~/components/QuestionnaireItemCard.vue";

interface ModelType {
  skillsToLearn: String[]
  skillsToLearnDescription: String
}

export default defineComponent({
  components: {
    QuestionnaireItemCard,
    NSpace, NForm, NFormItem, NButton, NRadio, NRadioGroup, NInput
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    const itemRefs = ref([])
    let selectedItems : String[] = []
    const maxSelectedItems = 3

    let formValue = ref(<ModelType>{
      skillsToLearn: [],
      skillsToLearnDescription: ''
    });

    function onQuestionnaireItemCardClick(key, index) {
      if (itemRefs.value[index].selected === true) {
        selectedItems = selectedItems.filter(item => item !== key)
        itemRefs.value[index].toggleSelected()
        formValue.value.skillsToLearn = selectedItems
        return
      }
      if(selectedItems.length >= maxSelectedItems) {
        this.message.warning('max items selected')
        return;
      }
      selectedItems.push(key)
      itemRefs.value[index].toggleSelected()
      formValue.value.skillsToLearn = selectedItems
    }

    const rules: FormRules = {
      skillsToLearnDescription: [
        {
          required: true,
          message: 'Beschrijving is verplicht.',
          trigger: ['blur']
        },
      ],
    }

    function handleValidateClick() {
      if(formValue.value.skillsToLearn.length < 1){
        this.message.error('Minimaal 1 antwoord is verplicht')
        throw new TypeError("SkillsToLearn is required")
      }
      return formRef.value?.validate()
          .then(() => Promise.resolve(formValue.value))
          .catch((errors) => Promise.reject(errors))
    }

    return {
      formRef,
      formValue,
      itemRefs,
      rules,
      handleValidateClick,
      onQuestionnaireItemCardClick,
      questionnaire: questionnaireData,
      maxSelectedItems,
      message: useMessage()
    }

  }
})


</script>

<style scoped>
h1 {
  text-align: center;
}
p {
  text-align: left;
  white-space: normal;
}
.questionnaire-grid {
  display: grid;
  grid-template-columns: 1fr;
  gap: 20px;
}
.questionnaire-card__container {
  display: flex;
}
.questionnaire-heading__subtitle {
  text-align: center;
  color: #999999;
}
.questionnaire-description {
   grid-column: span 3;
 }
.questionnaire-description__field {
  text-align: left;
}
@media (min-width: 1024px) {
  .questionnaire-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
</style>