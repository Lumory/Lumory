<template>
	<div class="content--center">
		<Container>
			<LogInForm />
		</Container>
	</div>
</template>

<script setup>
definePageMeta({
	layout: 'minimal-header',
});
</script>

<style scoped>
.content--center {
	display: flex;
	justify-content: center;
}
</style>
