<template #description>
    <n-card>
      <h1 style="font-size: 32px; font-weight: bolder; padding: 0rem;  line-height: 1;">
        {{internship?.name}}
      </h1>
      <p style="color: grey; font-size: 14px">
        {{internship?.city}}
      </p>
      <br>
      <n-tag style="margin-right: 15px; color: grey;">Marketing</n-tag>
      <n-tag style="color: grey">Advertising</n-tag>
      <br>
      <br>
      <div class="tutoring-container" style="display:flex; flex-direction: row">
        <person-sharp size="20" class="field-header__options-icon"/>
        <p class="tutoring">Gemiddelde begeleiding</p>
      </div>
      <br>
      <p style="font-weight: bolder;">Volledige vacaturetekst</p>
      <p style="font-size: 14px">
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