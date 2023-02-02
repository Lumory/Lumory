<template>
  <n-space style="margin-top: 200px">
    <n-grid cols="1 s:2" x-gap="100px" responsive="screen">
      <n-grid-item>
        <n-image
          src="/assets/img/img2.png"
          preview-disabled
        />
      </n-grid-item>
      <n-grid-item>
        <h3 class="titel">Op maat gemaakte matching</h3>
        <p class="text">
          Ons stageplatform biedt op maat gemaakte matching voor studenten door rekening te houden met hun specifieke wensen, vaardigheden en ambities. Onze geavanceerde zoekalgoritmen en koppelingen met topbedrijven garanderen snelle en efficiënte matching, waardoor studenten worden geplaatst bij stages die volledig aansluiten bij hun doelen.
        </p>
      </n-grid-item>
    </n-grid>
    <n-grid cols="1 s:2" x-gap="25px" style="margin-top: 200px" responsive="screen">
      <n-grid-item>
        <h3 class="titel">Kies zelf welke stages interessant zijn</h3>
        <p class="text">
          Op ons stageplatform hebben studenten de mogelijkheid om zelf te kiezen welke stages hen interessant lijken. Door middel van onze gebruiksvriendelijke zoekfunctie en een overzicht van beschikbare stages bij topbedrijven, kunnen studenten gericht zoeken naar stages die aansluiten bij hun specifieke interesses en ambities. Hierdoor krijgen studenten de kans om een stage te vinden die niet alleen aansluit bij hun carrière, maar ook bij wie ze zijn en wat ze willen bereiken.
        </p>
      </n-grid-item>
      <n-grid-item>
        <n-image
            src="/assets/img/img1.png"
            preview-disabled
        />
      </n-grid-item>
    </n-grid>
  </n-space>
</template>

<script>
import {NCarousel, NSpace, NGrid, NGridItem, NImage} from "naive-ui"

export default {
  components: {
    NCarousel,
    NSpace,
    NGrid,
    NGridItem,
    NImage
  }
}
</script>

<style scoped>
.carousel-img {
  width: 100%;
}
.text {
  width: 48ch;
  line-height: 24px;
  font-size: 18px;
}
.titel {
  font-style: normal;
  font-weight: 700;
  font-size: 40px;
  line-height: 47px;
}
</style>