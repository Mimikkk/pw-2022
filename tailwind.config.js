/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor, html, cshtml}"],
  theme: {
    extend: {
      transparent: "transparent",
      current: "currentColor",
    },
  },
  plugins: [],
}
