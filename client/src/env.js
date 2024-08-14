export const dev = window.location.origin.includes('localhost')

// REVIEW don't forget to change this URL if you're using a dotnet backend
export const baseURL = dev ? 'https://localhost:7045' : ''
export const useSockets = false
export const domain = 'dev-hhcu2170fadrfsij.us.auth0.com'
export const clientId = '9ky5h2ESpCSBmkWByEuMajyVhAiNBsZN'
export const audience = 'https://PortersAuthTest/'