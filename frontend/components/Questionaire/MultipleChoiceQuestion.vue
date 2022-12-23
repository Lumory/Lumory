<template>
  <n-radio-group class="radio-group" v-model:value="value" name="radiogroup">
    <p class="radio-group__question">{{question}}</p>
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
</template>

<script>

import {NSpace, NRadioGroup, NRadio, NButton} from 'naive-ui'
import {defineComponent} from "vue";

export default defineComponent({
  components: {
    NSpace, NButton, NRadio, NRadioGroup
  },
  props: ['question'],
})
</script>

<script setup>

definePageMeta({
  layout: 'minimal-header',
});
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
  padding: 0;
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
</style>