<template>
  <n-space class="services-section" justify="center">
    <h1>Wat bieden wij?</h1>
    <n-grid cols="1 s:3" x-gap="25px" responsive="screen">
      <n-grid-item class="n-grid-item">
        <n-image
            width="64"
            src="/assets/img/services2.png"
        />
        <h3>Snelle matching</h3>
        <p>Ons platform garandeert een snelle matching door gebruik te maken van geavanceerde matching-algoritmen en koppelingen met topbedrijven</p>
      </n-grid-item>
      <n-grid-item class="n-grid-item">
        <n-image
            width="64"
            src="/assets/img/services1.png"
        />
        <h3>Passende stage</h3>
        <p>Wij zorgen voor een perfecte match door rekening te houden met de wensen, vaardigheden en interesses van de student en de eisen en verwachtingen van bedrijven</p>
      </n-grid-item>
      <n-grid-item class="n-grid-item">
        <n-image
            width="64"
            src="/assets/img/services3.png"
        />
        <h3>Vliegende start</h3>
        <p>Wij bieden een vliegende start voor studenten door hen te koppelen aan relevante en uitdagende stages bij topbedrijven, waardoor ze waardevolle ervaring en vaardigheden opdoen</p>
      </n-grid-item>
    </n-grid>
  </n-space>
</template>

<script>
import {NGrid, NGridItem, NIcon, NSpace, NImage} from "naive-ui";
import {PinDropOutlined} from "@vicons/material";

export default {
  components: {
    NGrid,
    NGridItem,
    PinDropOutlined,
    NIcon,
    NSpace,
    NImage
  }
}
</script>

<style scoped>
.services-section {
  display: block;
  width: 80%;
  margin: 100px auto 0 auto;
}
h1 {
  text-align: center;
  display: block;
  font-weight: bold;
}
.n-grid-item {
  text-align: center;
  margin-bottom: 50px;
}

@media (min-width: 640px) {
  .services-section {
    width: 100%;
  }
  .n-grid {
    width: 100%;
  }
}
</style>