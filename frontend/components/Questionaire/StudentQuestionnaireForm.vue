<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Vul je gegevens in</h1>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules">
      <n-grid cols="12" :x-gap="24" item-responsive responsive="screen">
        <n-grid-item>
          <h3>Opleiding</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="study" label="Naam opleiding">
          <n-input v-model:value="formValue.study" placeholder="Open-ICT" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="studyDirection" label="Studierichting">
          <n-input v-model:value="formValue.studyDirection" placeholder="ICT" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="educationalInstitution" label="Onderwijsinstantie">
          <n-input v-model:value="formValue.educationalInstitution" placeholder="Hogeschool Utrecht" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="studyNiveau" label="Opleidings niveau">
          <n-input v-model:value="formValue.studyNiveau" placeholder="HBO" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-grid-item>
          <h3>Stage</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="internshipType" label="Soort stage">
          <n-input v-model:value="formValue.internshipType" placeholder="Afstudeerstage" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="dateStart" label="Startdatum">
          <n-input v-model:value="formValue.dateStart" placeholder="1-2-2023" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="hours" label="Aantal uur per week">
          <n-input v-model:value="formValue.hours" placeholder="32" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="days" label="Aantal dagen per week">
          <n-input v-model:value="formValue.days" placeholder="4" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-grid-item>
          <h3>Overig</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="city" label="Woonplaats">
          <n-input v-model:value="formValue.city" placeholder="Utrecht" @keydown.enter.prevent/>
        </n-form-item-gi>
      </n-grid>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, FormInst, NFormItemGi, NGrid, NGridItem, FormRules, FormItemRule} from 'naive-ui'
import { defineComponent, ref } from 'vue'

interface ModelType {
  city: string | null
  educationalInstitution: string | null
  study: string | null
  studyDirection: string | null
  studyNiveau: string | null
  averageGrade: number | null
  internshipType: string | null
  dateStart: string | null
  hours: number | null
  days: string | null
}

export default defineComponent({
  components: {
    NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, NFormItemGi, NGrid, NGridItem
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    let formValue = ref(<ModelType>{
      city: '',
      educationalInstitution: '',
      study: '',
      studyDirection: '',
      studyNiveau: '',
      averageGrade: 0,
      internshipType: '',
      dateStart: '',
      hours: 0,
      days: ''
    });
    const rules: FormRules = {
      city: [
        {
          required: true,
          message: 'Stad is verplicht.',
          trigger: ['blur']
        },
      ],
      educationalInstitution: [
        {
          required: true,
          message: 'Onderwijsinstantie is verplicht.',
          trigger: ['blur']
        },
      ],
      study: [
        {
          required: true,
          message: 'Opleiding is verplicht.',
          trigger: ['blur']
        },
      ],
      studyDirection: [
        {
          required: true,
          message: 'Studierichting is verplicht.',
          trigger: ['blur']
        },
      ],
      studyNiveau: [
        {
          required: true,
          message: 'Opleiding niveau is verplicht.',
          trigger: ['blur']
        },
      ],
      averageGrade: [
        {
          required: true,
          message: 'Gemiddeld cijfer is verplicht.',
          trigger: ['blur']
        },
      ],
      internshipType: [
        {
          required: true,
          message: 'Stage type is verplicht.',
          trigger: ['blur']
        },
      ],
      dateStart: [
        {
          required: true,
          message: 'Startdatum is verplicht.',
          trigger: ['blur']
        },
      ],
      hours: [
        {
          required: true,
          message: 'Uren is verplicht.',
          trigger: ['blur']
        },
      ],
      days: [
        {
          required: true,
          message: 'Dagen is verplicht.',
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
      rules,
      handleValidateClick
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
  font-family: "Roboto";
}
.form-item--left-align {
  text-align: left !important;
}
@media (min-width: 640px) {

}
</style>