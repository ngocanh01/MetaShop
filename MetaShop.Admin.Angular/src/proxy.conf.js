//Config to interact with api here
const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
    ],
    target: "https://localhost:7276",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
