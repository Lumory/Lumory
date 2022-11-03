<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Bedrijf informatie</h1>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules">
      <n-grid cols="12" :x-gap="24" item-responsive responsive="screen">
        <n-form-item-gi class="form-item--left-align" span="12" path="companyName" label="Bedrijfsnaam">
          <n-input v-model:value="formValue.companyName" placeholder="Bedrijf" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" span="12" path="KVK" label="KVK-nummer">
          <n-input v-model:value="formValue.KVK" placeholder="1234 5678 9012" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" :span="12" path="email" label="E-mail">
          <n-input v-model:value="formValue.email" placeholder="hr@bedrijf.nl" @keydown.enter.prevent />
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" :span="12" path="password" label="Wachtwoord">
          <n-input v-model:value="formValue.password" placeholder="Wachtwoord" @keydown.enter.prevent type="password" show-password-on="click"/>
        </n-form-item-gi>
        <n-form-item-gi class="form-item--left-align" :span="12" path="repeatPassword" label="Herhaal wachtwoord">
          <n-input v-model:value="formValue.repeatPassword" placeholder="Herhaal wachtwoord" @keydown.enter.prevent on-change="" type="password" show-password-on="click"/>
        </n-form-item-gi>
      </n-grid>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, FormInst, NFormItemGi, NGrid, FormRules, FormItemRule} from 'naive-ui'
import { defineComponent, ref } from 'vue'

interface ModelType {
  companyName: string | null
  KVK: string | null
  email: string | null
  password: string | null
  repeatPassword: string | null
}

export default defineComponent({
  components: {
    NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, NFormItemGi, NGrid
  },
  setup() {
    const formRef = ref<FormInst | null>(null)
    let formValue = ref(<ModelType>{
      companyName: '',
      KVK: '',
      email: '',
      password: '',
      repeatPassword: '',
    });
    const rules: FormRules = {
      companyName: [
        {
          required: true,
          message: 'Bedrijfsnaam is verplicht.',
          trigger: ['blur']
        },
      ],
      KVK: [
        {
          required: true,
          message: 'KVK-nummer is verplicht.',
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
      password: [
        {
          required: true,
          message: 'Wachtwoord is verplicht.',
          trigger: ['blur']
        },
      ],
      repeatPassword: [
        {
          validator (rule: FormItemRule, value: string) {
            return value == formValue.value.password;
          },
          message: 'Wachtwoord komt niet overeen.',
          trigger: ['blur']
        },
        {
          required: true,
          message: 'Herhaal wachtwoord is verplicht.',
          trigger: ['blur']
        },
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