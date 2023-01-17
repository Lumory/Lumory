<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Wat zijn jouw sterkste eigenschappen?</h1>
    <p class="questionnaire-heading__subtitle">(Max. {{maxSelectedItems}} keuzes)</p>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules" class="questionnaire-grid">
      <n-form-item class="questionnaire-card__container" v-for="(skill, key, index) in questionnaire.qualities" :key="key">
        <QuestionnaireItemCard :skill="skill" size="small" ref="itemRefs" @click="onQuestionnaireItemCardClick(key, index)"/>
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
  strongQualities: String[]
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
      strongQualities: [],
    });

    const onQuestionnaireItemCardClick = (key, index) => {
      if (itemRefs.value[index].selected === true) {
        selectedItems = selectedItems.filter(item => item !== key)
        itemRefs.value[index].toggleSelected()
        formValue.value.strongQualities = selectedItems
        return
      }
      if(selectedItems.length >= maxSelectedItems) {
        console.log('max items selected')
        return;
      }
      selectedItems.push(key)
      itemRefs.value[index].toggleSelected()
      formValue.value.strongQualities = selectedItems
    }

    const rules: FormRules = {
      strongQualities: [
        {
          required: true,
          message: 'Vraagstuk is verplicht.',
          trigger: ['blur']
        },
      ],
    }

    const handleValidateClick = () => {
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
      maxSelectedItems
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