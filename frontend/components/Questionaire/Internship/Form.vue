<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Vul je bedrijfgegevens in</h1>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules">
      <n-grid cols="12" :x-gap="24" item-responsive responsive="screen">
        <n-grid-item>
          <h3>Basis</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="dateStart" label="Startdatum">
          <n-input v-model:value="formValue.dateStart" placeholder="01-02-2023" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="hours" label="Aantal uren">
          <n-input v-model:value="formValue.hours" placeholder="36" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="applyBefore" label="Sluitdatum">
          <n-input v-model:value="formValue.applyBefore" placeholder="01-02-2023" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="money" label="Vergoeding per maand">
          <n-input v-model:value="formValue.money" placeholder="Geen vergoeding" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="remoteWork" label="Remote werken">
          <n-input v-model:value="formValue.remoteWork" placeholder="Gedeeltelijk" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-grid-item>
          <h3>Rol</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="function" label="Functie">
          <n-input v-model:value="formValue.function" placeholder="Koffie haler" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="responsability" label="Verantwoordelijkheid">
          <n-input v-model:value="formValue.responsability" placeholder="Lekkere koffie halen" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="workExperience" label="Werkervaring">
          <n-input v-model:value="formValue.workExperience" placeholder="1 jaar" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-grid-item>
          <h3>Bedrijf</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="staff" label="Aantal medewerkers">
          <n-input v-model:value="formValue.staff" placeholder="12 werknemers" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="website" label="Website">
          <n-input v-model:value="formValue.website" placeholder="https://www.lumory.nl" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="streetAddress" label="Straat">
          <n-input v-model:value="formValue.streetAddress" placeholder="Straatweg 123" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="city" label="Plaats">
          <n-input v-model:value="formValue.city" placeholder="Utrecht" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="international" label="international">
          <n-input v-model:value="formValue.international" placeholder="Internationaal" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-grid-item>
          <h3>Contactpersoon</h3>
        </n-grid-item>
        <n-form-item-gi class="form-item--left-align" span="12" path="contactPersonFirstName" label="Voornaam">
          <n-input v-model:value="formValue.contactPersonFirstName" placeholder="Jane" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="contactPersonLastName" label="Achternaam">
          <n-input v-model:value="formValue.contactPersonLastName" placeholder="Doe" @keydown.enter.prevent/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="contactPersonEmail" label="E-mail">
          <n-input v-model:value="formValue.contactPersonEmail" placeholder="janedoe@gmail.com" @keydown.enter.prevent/>
        </n-form-item-gi>
      </n-grid>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, FormInst, NFormItemGi, NGrid, NGridItem, FormRules, FormItemRule} from 'naive-ui'
import { defineComponent, ref } from 'vue'

interface ModelType {
  money: String | null
  remoteWork: String | null
  function: String | null
  responsability: String | null
  workExperience: String | null
  staff: String | null
  website: String | null
  streetAddress: String | null
  city: String | null
  contactPersonFirstName: String | null
  contactPersonLastName: String | null
  contactPersonEmail: String | null
  international: String | null
  dateStart: String | null
  hours: String | null
  applyBefore: String | null
}

export default defineComponent({
  components: {
    NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, NFormItemGi, NGrid, NGridItem
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    let formValue = ref(<ModelType>{
      money: '',
      remoteWork: '',
      function: '',
      responsability: '',
      workExperience: '',
      staff: '',
      website: '',
      streetAddress: '',
      city: '',
      contactPersonFirstName: '',
      contactPersonLastName: '',
      contactPersonEmail: '',
      international: '',
      dateStart: '',
      hours: '',
      applyBefore: ''
    });
    const rules: FormRules = {
      money: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      remoteWork: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      function: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      responsability: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      workExperience: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      staff: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      website: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      streetAddress: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      city: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      contactPersonFirstName: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      contactPersonLastName: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      contactPersonEmail: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      international: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      dateStart: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      hours: [
        {
          required: true,
          message: 'Veld is verplicht',
          trigger: ['blur']
        },
      ],
      applyBefore:[
        {
          required: true,
          message: 'Veld is verplicht',
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