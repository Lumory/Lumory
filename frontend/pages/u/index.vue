<template>
	<h1>Dit is de user pagina</h1>
</template>

<script lang="ts">
	definePageMeta({
		middleware: "check-auth"
	})
</script>
