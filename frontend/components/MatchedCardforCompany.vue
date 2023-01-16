<!-- child component for all matched interns for a company (internship company) -->

<template>
  <n-space>
    <n-card :bordered="false" class="matched-container" hoverable
    >
      <template #header>
        <ellipsis-vertical size="20" class="field-header__person-icon"/>
        <n-space class="internshipText">
          {{ this.intern.firstName }}
        </n-space>
        <n-space class="cityText">
          {{ this.intern.lastName }}
        </n-space>
      </template>
      <n-space>
        <n-tag class="tag">Marketing</n-tag>
        <n-tag class="tag">Advertising</n-tag>
      </n-space>
      <template class="tutoring-container">
        <n-space>
          <person-sharp size="20" class="field-header__person-icon"/>
          <n-space>Gemiddelde begeleiding</n-space>
        </n-space>
      </template>
      <n-space vertical>
        <n-space>
          -
          {{ this.intern?.sectorDescription }}
        </n-space>
        <n-space class="lastPostedText">
          15 dagen geleden geplaatst
        </n-space>
      </n-space>
    </n-card>
  </n-space>
</template>

<script>
import {PersonSharp, EllipsisVertical} from "@vicons/ionicons5";
import {NTag, NCard, NSpace, NGrid} from "naive-ui";

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
    NSpace,
    NGrid
  },
  name: "MatchedCardForCompany",

  // object
  props: {
    intern: ''
  },
  data() {
    return {
      currentHighlightedIntern: ""
    }
  },
}
</script>
<style scoped>
.internshipText {
  font-size: 32px;
  font-weight: bolder;
  padding: 0;
  margin: 0;
  line-height: 1;
}

.lastPostedText {
  color: grey;
}

.cityText {
  color: grey;
  font-size: 14px;
  padding: 0;
  margin: 0;
}

.tag {
  color: grey;
}

.field-header__person-icon {
  height: 20px;
  float: right
}

.matched-container {
  width: 380px;
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
