<template>
  <container>
    <n-space vertical justify="start" align="center">
      <QuestionaireStepper />
    </n-space>
  </container>
</template>

<script setup>
import QuestionaireStepper from "../components/QuestionaireStepper";

definePageMeta({
  layout: 'minimal-header',
});
</script>
