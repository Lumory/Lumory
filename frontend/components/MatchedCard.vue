<template #description>
  <n-card :bordered="false" class="matched-container" hoverable
  >
    <ellipsis-vertical style="float: right" size="20" class="field-header__options-icon"/>
      <h1 style="font-size: 36px; padding: 0rem">
        {{ this.internship.name }}
      </h1>
    <p style="color: grey;">
      {{ this.internship.city }}
    </p>
    <n-tag style="margin-right: 15px">Marketing</n-tag>
    <n-tag>Advertising</n-tag>
    <br>
    <br>
    <div class="tutoring-container" style="display:flex; flex-direction: row">
      <person-sharp size="20" class="field-header__options-icon"/>
      <p>Gemiddelde begeleiding</p>
    </div>
    <br>
    <p>
      {{ this.internship.description }}
    </p>
    <br>
    <p style="color:grey">
      15 dagen geleden geplaatst
    </p>
  </n-card>
</template>

<script>
import Container from "./Container";
import {PersonSharp, EllipsisVertical} from "@vicons/ionicons5";
import {NTag, NCard, NIcon} from "naive-ui";
import axios from "axios"

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
    NIcon,
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
.field-header__options-icon {
  height: 20px;
}

.matched-container:hover {
  border: 1.5px solid black;
}

</style>