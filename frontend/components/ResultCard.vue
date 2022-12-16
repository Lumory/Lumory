<template #description>
    <n-card>
      <h1 style="font-size: 36px; padding: 0rem">
        {{internship?.name}}
      </h1>
      <p style="color: grey;">
        {{internship?.website}}
      </p>
      <n-tag style="margin-right: 15px">Marketing</n-tag>
      <n-tag>Advertising</n-tag>
      <br>
      <br>
      <div class="tutoring-container" style="display:flex; flex-direction: row">
        <person-sharp size="20" class="field-header__options-icon"/>
        <p class="tutoring">Gemiddelde begeleiding</p>
      </div>
      <br>
      <p style="font-weight: bolder;">Volledige vacaturetekst</p>
      <p>
        {{this.internship?.description}}
      </p>
    </n-card>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import {NCard, NTag, NScrollbar, NSpace, NIcon} from "naive-ui";

export default {
  components: {
    PersonSharp,
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
.field-header__options-icon {
  height: 20px;
}
</style>