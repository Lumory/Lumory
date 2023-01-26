<!-- child component for all matched interns for a user (intern) -->
<template #header>
  <n-space vertical>
    <n-card :bordered="false" class="matched-container" hoverable
    >
        <ellipsis-vertical size="20" class="field-header__person-icon"/>
        <n-space class="internship-text">
          {{ this.internship.problem }}
        </n-space>
        <n-space class="city-text">
          {{ this.internship.city }}
        </n-space>
      <n-space>
        <n-tag class="tag">Marketing</n-tag>
        <n-tag class="tag">Advertising</n-tag>
      </n-space>
        <n-space class="tutoring-container">
          <person-sharp size="20" class="field-header__person-icon"/>
          <n-space>Gemiddelde begeleiding</n-space>
        </n-space>
      <n-space vertical>
        <n-space>
          -
          {{ this.internship?.sectorDescription }}
        </n-space>
        <n-space class="last-posted-text">
          15 dagen geleden geplaatst
        </n-space>
      </n-space>
    </n-card>
  </n-space>
</template>

<script>
import {PersonSharp, EllipsisVertical} from "@vicons/ionicons5";
import {NTag, NCard, NSpace} from "naive-ui";

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
    NSpace,
  },
  name: "matchedCard",

  // object
  props: {
    internship: ''
  },
  data() {
    return {
      currentHighlightedInternship: ""
    }
  },
}
</script>
<style scoped>
.internship-text {
  font-size: 32px;
  font-weight: bolder;
  padding: 0;
  margin: 0;
  line-height: 1;
}

.last-posted-text {
  color: grey;
}

.city-text {
  color: grey;
  font-size: 14px;
  padding: 0;
  margin: 0;
}

.tag {
  color: grey;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
}

.field-header__person-icon {
  height: 20px;
  float: right
}

.matched-container:hover {
  border: 1.5px solid black;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
  margin-top: 15px;
  margin-bottom: 15px;
}
</style>
