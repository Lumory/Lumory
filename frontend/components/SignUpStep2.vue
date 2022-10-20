<template>
  <n-space vertical align="center">
    <h1>Persoonlijke informatie</h1>
    <n-space align="center" vertical>


      <n-form ref="formRef" :model="model" size="large">
        <n-grid :span="24" :x-gap="24">
          <n-form-item-gi :span="12" path="firstName" label="firstName">
            <n-input v-model:value="model.firstName" @keydown.enter.prevent />
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
import {NSpace, NForm, NRow, NCol, NButton, NFormItem, NInput, FormInst, NFormItemGi, NGrid} from 'naive-ui'
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

    return {
      formRef,
      model: modelRef,
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
  text-align: center;
}
.n-radio-group .n-radio-button {
  width: 250px;
  height: 200px;
  padding: 25px;
  transition: all 250ms ease;
  will-change: transition;
  display: inline-block;
  text-align: center;
  cursor: pointer;
  position: relative;
  font-weight: 900;
  border-radius: 15px;
  border: 3px solid #d9d9d9;
  font-family: "Roboto";
}
p {
  text-align: left;
  white-space: normal;
  font-family: "Roboto";
}
@media (min-width: 640px) {

}
</style>