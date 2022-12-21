module.exports = {
	preset: 'ts-jest',
	testEnvironment: "node",
	transform: {
    '^.+\\.ts?$': 'ts-jest',
  },
	globals: {
			'ts-jest': {
					tsconfig: '<rootDir>/tsconfig.json',
			},
	},
	transformIgnorePatterns: [
			"node_modules/(?!troublesome-dependency/.*)",
	],
}