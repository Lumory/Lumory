<template>
  <n-space vertical align="center" item-style="width: 100%">
    <h1>Persoonlijke informatie</h1>
    <n-form ref="formRef" :model="formValue" size="large" :rules="rules">
      <n-form-item path="Q2">
        <n-radio-group class="radio-group" v-model:value="formValue.Q2" name="radiogroup">
          <p class="radio-group__question">Hoe veel begeleiding wil je hebben?</p>
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
      </n-form-item>
    </n-form>
  </n-space>
</template>

<script lang="ts">
import {NSpace, NForm, NFormItem,  NRadioGroup, NRadio, NButton, FormInst, FormRules, FormItemRule} from 'naive-ui'
import {defineComponent, ref} from "vue";

interface ModelType {
  Q1: string | null
  Q2: string | null
}

export default defineComponent({
  components: {
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