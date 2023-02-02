<template>
  <div class="landing-page-layout">
    <TheHeader />
    <slot />
    <TheFooter/>
  </div>
</template>

<style scoped>
.landing-page-layout {
  display: flex;
  min-height: 100vh;
  flex-direction: column;
  justify-content: space-between;
  background: url("assets/img/landing-page_background.svg") no-repeat center top;

  background-image: url("assets/img/bg1.png");
  background-image: -webkit-image-set(
      url("assets/img/bg1.png") 1x,
      url("assets/img/bg1.png") 2x);
  background-image: image-set(
      url("assets/img/bg1.png") 1x,
      url("assets/img/bg1.png") 2x);

}

</style>