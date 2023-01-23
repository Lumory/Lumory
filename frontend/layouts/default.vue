<template>
	<div class="default-layout">
		<TheHeader />
		<slot />
    <TheFooter/>
	</div>
</template>

<style scoped>
.default-layout {
  display: flex;
  min-height: 100vh;
  flex-direction: column;
  justify-content: space-between;
}

</style>