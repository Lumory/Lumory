<template>
  <n-card>
    <h1 class="nameText">
      {{ internship?.name }}
    </h1>
    <p class="cityText">
      {{ internship?.city }}
    </p>
    <br>
    <div>
      <n-tag class="tag">Marketing</n-tag>
      <n-tag class="tag">Advertising</n-tag>
    </div>
    <br>
    <div class="tutoring-container">
      <person-sharp size="20" class="field-header__person-icon"/>
      <p class="tutoring">Gemiddelde begeleiding</p>
    </div>
    <br>
    <p class="vacancyText">Volledige vacaturetekst</p>
    <p class="descriptionText">
      {{ this.internship?.description }}
    </p>
  </n-card>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import {NCard, NTag} from "naive-ui";

export default {
  components: {
    PersonSharp,
    NCard,
    NTag,
  },
  name: "ResultCard",
  matchedresults: [],
  currentHighlightedInternship: '',
  props: {
    internship: {}
  },
}
</script>
<style scoped>
.vacancyText {
  font-weight: bolder;
}

.field-header__person-icon {
  height: 20px;
}

.descriptionText {
  font-size: 14px;
}

.cityText {
  color: grey;
  font-size: 14px;
}

.tag {
  color: grey;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
}

.nameText {
  font-size: 32px;
  font-weight: bolder;
  padding: 0rem;
  line-height: 1;
}
</style>