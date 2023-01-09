<template>
  <n-space vertical>
    <n-card :bordered="false" class="matched-container" hoverable
    >
      <template #header>
        <ellipsis-vertical size="20" class="field-header__person-icon"/>
        <n-space class="internshipText">
          {{ this.internship.name }}
        </n-space>
        <n-space class="cityText">
          {{ this.internship.city }}
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
        <n-space v-for="(item) in items">
          -
          {{ item.message }}
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
import {NTag, NCard, NSpace} from "naive-ui";

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
    NSpace,
  },
  name: "MatchedCard",
  props: {
    internship: ''
  },
  data() {
    return {
      currentHighlightedInternship: "",
      items: [
        {message: 'Leuke stage'},
        {message: 'Veel leermogelijkheden'}
      ],
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