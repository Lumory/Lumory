<template>
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
</template>

<script>

import {NSpace, NRadioGroup, NRadio, NButton} from 'naive-ui'
import {defineComponent} from "vue";

export default defineComponent({
  components: {
    NSpace, NButton, NRadio, NRadioGroup
  },
})
</script>

<script setup>

definePageMeta({
  layout: 'minimal-header',
});
</script>
