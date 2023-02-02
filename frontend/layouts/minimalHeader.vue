<template>
	<div class="minimal-header-layout">
		<TheMinimalHeader />
		<slot />
	</div>
</template>

<style>
.minimal-header-layout {
	display: flex;
	flex-direction: column;
}
</style>

<script setup></script>
