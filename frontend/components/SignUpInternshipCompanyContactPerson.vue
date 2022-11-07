<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Contactpersoon toevoegen</h1>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules">
      <n-grid cols="12" :x-gap="24" item-responsive responsive="screen">
        <n-form-item-gi class="form-item--left-align" span="12 s:6" path="firstName" label="Voornaam">
          <n-input v-model:value="formValue.firstName" placeholder="John" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12 s:6" path="lastName" label="Achternaam">
          <n-input v-model:value="formValue.lastName" placeholder="Doe" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" :span="12" path="email" label="E-mail">
          <n-input v-model:value="formValue.email" placeholder="johndoe@e.mail" @keydown.enter.prevent />
        </n-form-item-gi>
      </n-grid>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, FormInst, NFormItemGi, NGrid, FormRules, FormItemRule} from 'naive-ui'
import { defineComponent, ref } from 'vue'

interface ModelType {
  firstName: string | null
  lastName: string | null
  email: string | null
}

export default defineComponent({
  components: {
    NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, NFormItemGi, NGrid
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    let formValue = ref(<ModelType>{
      firstName: '',
      lastName: '',
      email: '',
    });
    const rules: FormRules = {
      firstName: [
        {
          required: true,
          message: 'Voornaam is verplicht.',
          trigger: ['blur']
        },
      ],
      lastName: [
        {
          required: true,
          message: 'Achternaam is verplicht.',
          trigger: ['blur']
        },
      ],
      email: [
        {
          required: true,
          validator (rule: FormItemRule, value: string) {
            if (!/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(value)) {
              console.log('ongeldige email')
              return new Error('Invalid email format')
            }
          },
          message: 'Vul een geldig email adres in.',
          trigger: ['blur']
        }
      ],
    }

    return {
      formRef,
      formValue,
      rules,
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