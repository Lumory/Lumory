<template>
  <n-space vertical align="center">
    <h1>Persoonlijke informatie</h1>
    <n-space vertical>


      <n-form ref="formRef" :model="model" size="large" :rules="rules">
        <n-grid :span="24" :x-gap="24">
          <n-form-item-gi :span="12" path="firstName" label="firstName">
            <n-input v-model:value="model.firstName" placeholder="Whatever" @keydown.enter.prevent />
          </n-form-item-gi>

          <n-form-item-gi :span="12" path="lastName" label="LastName">
            <n-input v-model:value="model.lastName" @keydown.enter.prevent />
          </n-form-item-gi>
          <n-form-item-gi :span="24" path="email" label="Email">
            <n-input v-model:value="model.email" @keydown.enter.prevent />
          </n-form-item-gi>
          <n-form-item-gi :span="24" path="password" label="Password">
            <n-input v-model:value="model.password" @keydown.enter.prevent type="password" />
          </n-form-item-gi>
        </n-grid>
      </n-form>


    </n-space>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, FormInst, NFormItemGi, NGrid, FormRules, FormItemRule} from 'naive-ui'
import { defineComponent, ref } from 'vue'

interface ModelType {
  firstName: string | null
  lastName: string | null
  email: string | null
  password: string | null
}

export default defineComponent({
  components: {
    NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, NFormItemGi, NGrid
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    const modelRef = ref<ModelType>({
      firstName: null,
      lastName: null,
      email: null,
      password: null,
    })
    const rules: FormRules = {
      firstName: [
        {
          required: true,
          message: 'Voornaam is verplicht.',
          trigger: ['blur']
        },
      ],
      email: [
        {
          required: true,
          validator (rule: FormItemRule, value: string) {
            if (!/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(value)) {
              console.log('ongeldige email')
              return new Error('Age should be an integer')
            }
          },
          message: 'Vul een geldig email adres in.',
          trigger: ['blur']
        }
      ]
    }

    return {
      formRef,
      model: modelRef,
      rules,
      formValue: ref({
        firstName: '',
        lastName: '',
        email: '',
        password: '',
      }),
    }
  }
})
</script>

<style scoped>
h1 {
  text-align: left;
}
p {
  text-align: left;
  white-space: normal;
  font-family: "Roboto";
}
@media (min-width: 640px) {

}
</style>