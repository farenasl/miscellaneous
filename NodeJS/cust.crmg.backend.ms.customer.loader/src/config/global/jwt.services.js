//!IMPORTAMOS PROPERTIES
const {JWT_EXPIRATION} = process.env;

module.exports = (jwt, json) => {
  const JWT_ALGORITHM  = json.algorithm
  const JWT_SECRET = json.secret
  const JWT_KEY = json.key
  return {
    generateToken: () => {
      return jwt.sign({
        "iss": JWT_KEY
      }, JWT_SECRET, {
        algorithm: JWT_ALGORITHM,
        expiresIn: JWT_EXPIRATION
      })
    },

  }
}