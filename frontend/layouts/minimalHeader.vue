<template>
	<div class="default-layout">
		<TheMinimalHeader />
		<slot />
	</div>
</template>

<style>
.default-layout {
	display: flex;
	flex-direction: column;
}
</style>

<script setup></script>
