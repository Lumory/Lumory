<template>
  <n-card :bordered="false">
    <h1 style="font-size: 34px; padding: 0rem">
      {{this.internship.name}}
    </h1>
    <p>
      {{this.internship.city}}
    </p>
    <n-tag style="margin-right: 15px">Marketing</n-tag>
    <n-tag>Advertising</n-tag>
    <p>
      {{this.internship.description}}
    </p>
  </n-card>
</template>

<script>
import Container from "./Container";
import {NList, NListItem, NThing, NTag, NSpace, NScrollbar, NButton, NCard} from "naive-ui";
import axios from "axios"

export default {
  components: {
    NList,
    NListItem,
    NThing,
    NTag,
    NSpace,
    NScrollbar,
    NButton,
    NCard
  },
  props: {
    internship: {}
  },
  name: "MatchedCard",
  data() {
    return {
      currentHighlightedInternship: ""
    }
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedInternship = index
    }
  }
}
</script>
<style scoped>
</style>