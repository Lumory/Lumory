<template>
  <n-space vertical>
    <n-card>
      <template #header>
        <n-space class="cardTitle">
          {{ internship?.problem }}
        </n-space>
        <n-space class="cardCity">
          {{ internship?.city }}
        </n-space>
      </template>
      <n-space>
        <n-tag class="tag">Marketing</n-tag>
        <n-tag class="tag">Advertising</n-tag>
      </n-space>
      <template class="tutoring-container">
        <n-space>
          <person-sharp size="20" class="field-header__person-icon"/>
          <n-space class="tutoring">Gemiddelde begeleiding</n-space>
        </n-space>
      </template>
      <n-space style="font-weight: bolder">
        Volledige Vacaturetekst
      </n-space>
      <n-space class="descriptionText">
        {{ this.internship?.problemDescription }}
      </n-space>
    </n-card>
  </n-space>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import {NCard, NTag, NSpace} from "naive-ui";

export default {
  components: {
    PersonSharp,
    NCard,
    NTag,
    NSpace
  },
  name: "DetailedCard",
  matchedresults: [],
  props: {
    internship: {}
  },
}
</script>
<style scoped>


.field-header__person-icon {
  height: 20px;
}

.cardTitle {
  font-weight: 800;
  font-size: 32px;
  line-height: 1;
}

.descriptionText {
  font-size: 14px;
}

.cardCity {
  color: grey;
  font-size: 14px;
}

.tag {
  color: grey;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
  margin-top: 15px;
  margin-bottom: 15px;
}
</style>
