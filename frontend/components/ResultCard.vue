<template #description>
    <n-card style="padding: 5px">
      <h1 style="font-size: 25px; padding: 0rem">
        {{internship?.name}}
      </h1>
      <p>
        {{internship?.website}}
      </p>
      <n-tag style="margin-right: 15px">Marketing</n-tag>
      <n-tag>Advertising</n-tag>
      <br>
      <br>
      <p style="font-weight: bolder;">Volledige vacaturetekst</p>
      <p>
        {{this.internship?.description}}
      </p>
    </n-card>
</template>

<script>
import {NCard, NTag, NScrollbar, NSpace} from "naive-ui";

export default {
  components: {
    NCard,
    NTag,
    NScrollbar,
    NSpace
  },
  name: "ResultCard",
  matchedresults: [],
  currentHighlightedInternship: '',
  props: {
    internship: {}
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedInternship = index
      console.log(this.currentHighlightedInternship)
    }
  }
}
</script>
<style scoped>
</style>