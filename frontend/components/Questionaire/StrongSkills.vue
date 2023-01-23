<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Wat zijn jouw sterkste vaardigheden?</h1>
    <p class="questionnaire-heading__subtitle">(Max. {{maxSelectedItems}} keuzes)</p>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules" class="questionnaire-grid">
      <n-form-item class="questionnaire-card__container" v-for="(skill, key, index) in questionnaire.skills" :key="key">
        <QuestionnaireItemCard :skill="skill" size="small" ref="itemRefs" @click="onQuestionnaireItemCardClick(key, index)"/>
      </n-form-item>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NFormItem,  NRadioGroup, NRadio, NButton, FormInst, FormRules, useMessage} from 'naive-ui'
import {defineComponent, ref} from "vue";
import questionnaireData from '../../assets/json/questionaire.json'
import QuestionnaireItemCard from "~/components/QuestionnaireItemCard.vue";

interface ModelType {
  strongSkills: String[]
}

export default defineComponent({
  components: {
    QuestionnaireItemCard,
    NSpace, NForm, NFormItem, NButton, NRadio, NRadioGroup
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    const itemRefs = ref([])
    let selectedItems : String[] = []
    const maxSelectedItems = 3

    let formValue = ref(<ModelType>{
      strongSkills: [],
    });

    function onQuestionnaireItemCardClick(key, index) {
      if (itemRefs.value[index].selected === true) {
        selectedItems = selectedItems.filter(item => item !== key)
        itemRefs.value[index].toggleSelected()
        formValue.value.strongSkills = selectedItems
        return
      }
      if(selectedItems.length >= maxSelectedItems) {
        this.message.warning('max items selected')
        return;
      }
      selectedItems.push(key)
      itemRefs.value[index].toggleSelected()
      formValue.value.strongSkills = selectedItems
    }

    const rules: FormRules = {
      strongSkills: [
        {
          required: true,
          message: 'Vraagstuk is verplicht.',
          trigger: ['blur']
        },
      ],
    }

    function handleValidateClick() {
      if(formValue.value.strongSkills.length < 1){
        this.message.error('Minimaal 1 antwoord is verplicht')
        throw new TypeError("StrongSkills is required")
      }
      return Promise.resolve(formValue.value)
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
@media (min-width: 1024px) {
  .questionnaire-grid {
    grid-template-columns: repeat(3, 1fr);
  }
}
</style>