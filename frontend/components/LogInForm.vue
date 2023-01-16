<template>
	<div class="log-in-container">
		<h2>Inloggen</h2>
		<div class="inlog-form">
			<n-form
				:label-width="80"
				:model="formValue"
				:rules="rules"
				:size="size"
				ref="formRef"
			>
				<n-form-item label="E-mail" path="email">
					<n-input v-model:value="formValue.email" placeholder="E-mail" />
				</n-form-item>
				<n-form-item label="Wachtwoord" path="password">
					<n-input
						type="password"
						show-password-on="click"
						placeholder="Wachtwoord"
						v-model:value="formValue.password"
					/>
				</n-form-item>
				<n-grid :cols="2">
					<n-form-item-gi path="rememberMe" label-placement="left">
						<n-checkbox v-model:checked="formValue.rememberMe"
							>Onthoud mij</n-checkbox
						>
					</n-form-item-gi>
					<n-gi class="grid__item--flex">
						<NuxtLink class="forgot-password--alignment" to="/forgotpassword">
							<u>Wachtwoord vergeten?</u>
						</NuxtLink>
					</n-gi>
				</n-grid>
				<n-button
					class="button--size button--spacing"
					@click="handleValidateClick(formValue)"
					attr-type="submit"
					type="primary"
					>Log in</n-button
				>
			</n-form>
			<NuxtLink to="/signup">
				<n-button class="button--size button--spacing">Registreren</n-button>
			</NuxtLink>
		</div>
	</div>
</template>

<script lang="ts">
import {
	NForm,
	NFormItem,
	NInput,
	NButton,
	useMessage,
	FormItemRule,
	NGrid,
	NGi,
	NCheckbox,
	NFormItemGi,
	FormInst,
} from 'naive-ui';
import axios from 'axios';
import authService from '../services/AuthService.js';

export default defineComponent({
	setup() {
		const formRef = ref<FormInst | null>(null);
		const message = useMessage();
		return {
			formRef,
			size: ref<'large'>('large'),
			formValue: ref<ModelType>({
				email: null,
				password: null,
				rememberMe: false,
			}),
			rules: {
				email: {
					required: true,
					message: 'Incorrecte e-mail',
					trigger: ['input', 'blur'],
					validator(rule: FormItemRule, value: string) {
						if (
							!/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(
								value
							)
						) {
							return new Error('Age should be an integer');
						}
					},
				},
				password: {
					required: true,
					message: 'Vul je wachtwoord in',
					trigger: ['input', 'blur'],
				},
				rememberMe: {
					required: false,
				},
			},
			handleValidateClick(values) {
				formRef.value.validate((errors: any) => {
					if (!errors) {
						const config = {
							"email": values.email,
							"password": values.password
						}
						authService.logIn(config).then(response => {
							const jwt = useCookie<{ name: string, options: object }>('JWT', {
								maxAge: 300,
								sameSite: 'strict'
							})
							jwt.value = response
							navigateTo(`/u/${jwt.value['id']}`)
						})
						.catch(error => {
							if (error.response.status === 401) {
								message.error('Incorrect password')
							} else if (error.response.status === 404) {
								message.error('Invalid email address')
							} else {
								message.error('User does not exist')
							}
						})
					} else {
						message.error('Ongeldig wachtwoord en/of e-mail adres');
					}
				});
			},
		};
	},
	components: {
		NForm,
		NFormItem,
		NButton,
		NInput,
		NGi,
		NGrid,
		NCheckbox,
		NFormItemGi,
	},
});

interface ModelType {
	email: string | null;
	password: string | null;
	rememberMe: boolean | null;
}
</script>

<style scoped>
.log-in-container {
	display: flex;
	justify-content: center;
	align-items: center;
	flex-direction: column;
}
.grid__item--flex {
	display: flex;
	align-items: center;
}
.forgot-password--alignment {
	height: 40px;
	text-align: end;
}
.button--size {
	width: 100%;
}
.button--spacing {
	margin-top: 5px;
	margin-bottom: 5px;
}

@media (min-width: 1024px) {
	.log-in-container {
		margin-top: 100px;
	}
}
</style>
