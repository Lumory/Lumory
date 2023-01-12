<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Aan welk type vraagstuk waar zou willen werken?</h1>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules" class="questionnaire-grid">
      <n-form-item class="questionnaire-card__container" v-for="problem in questionnaire.problem" path="Q1">
        <QuestionnaireItemCard :skill="problem" size="small"/>
      </n-form-item>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NFormItem,  NRadioGroup, NRadio, NButton, FormInst, FormRules} from 'naive-ui'
import {defineComponent, ref} from "vue";
import questionnaireData from '../../assets/json/questionaire.json'
import QuestionnaireItemCard from "~/components/QuestionnaireItemCard.vue";

interface ModelType {
  Q1: string | null
  Q2: string | null
}

export default defineComponent({
  components: {
    QuestionnaireItemCard,
    NSpace, NForm, NFormItem, NButton, NRadio, NRadioGroup
  },
  setup() {
    const formRef = ref<FormInst | null>(null)

    let formValue = ref(<ModelType>{
      Q1: '',
      Q2: '',
    });

    const rules: FormRules = {
      Q1: [
        {
          required: true,
          message: 'Q1 is verplicht.',
          trigger: ['blur']
        },
      ],
      Q2: [
        {
          required: true,
          message: 'Q2 is verplicht.',
          trigger: ['blur']
        },
      ],
    }

    const handleValidateClick = () => {
      return formRef.value?.validate()
    }

    return {
      formRef,
      formValue,
      rules,
      handleValidateClick,
      questionnaire: questionnaireData,
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
@media (min-width: 1024px) {
  .questionnaire-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
</style>