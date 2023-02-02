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
  background: url("assets/img/bg1.png") no-repeat center top;
  background-size: 1440px;
}

</style>