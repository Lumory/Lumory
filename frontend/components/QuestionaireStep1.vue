<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Persoonlijke informatie</h1>
    <n-radio-group class="radio-group" v-model:value="value" name="radiogroup">
      <p class="radio-group__question">Hoeveel begeleiding zou je willen?</p>
      <n-space justify="space-between" class="radio-group__buttons">
        <p class="radio-group__label">Weinig</p>
        <n-radio
            key="1"
            value="test1"
        />
        <n-radio
            key="2"
            value="test2"
        />
        <n-radio
            key="3"
            value="test3"
        />
        <n-radio
            key="4"
            value="test4"
        />
        <n-radio
            key="5"
            value="test5"
        />
        <p class="radio-group__label">Veel</p>
      </n-space>
    </n-radio-group>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NRadioGroup, NRadio, NButton, FormInst, FormRules, FormItemRule} from 'naive-ui'
import {defineComponent, ref} from "vue";

interface ModelType {
  companyName: string | null
  KVK: string | null
  email: string | null
  password: string | null
  repeatPassword: string | null
}

export default defineComponent({
  components: {
    NSpace, NButton, NRadio, NRadioGroup
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

    const handleValidateClick = () => {
      formRef.value?.validate((errors) => {
        return !!errors
      })
    }

    return {
      value: ref(null),
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
}
.radio-group {
  width: 100%;
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 0px;
  gap: 25px;
}
.radio-group__question {
  font-style: normal;
  font-weight: 700;
  font-size: 16px;
  line-height: 19px;
}
.radio-group__buttons {
  flex: none;
  order: 0;
  align-self: stretch;
  flex-grow: 0;
}
.radio-group__label {
  color: #999999;
}
@media (min-width: 640px) {

}
</style>