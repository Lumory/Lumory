<template>
	<div class="default-layout">
		<TheMinimalHeader />
		<slot />
	</div>
</template>

<style>
.default-layout {
	display: flex;
	min-height: 100vh;
	flex-direction: column;
}
</style>

<script setup></script>
