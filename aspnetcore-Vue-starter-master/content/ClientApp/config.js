export const getHeader = function () {
  const tokenData = JSON.parse(window.localStorage.getItem('lbUser'))
  const headers = {
    'Accept': 'application/json',
    'Authorization': 'Bearer' + tokenData.access_token
  }
  return headers
}
