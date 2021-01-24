const path = require('path');

module.exports = [
    {
        entry: ['babel-polyfill', './wwwroot/js/site/script.js'],
        output: {
            filename: 'site.js',
            path: path.join(__dirname, './wwwroot/js'),
        },
        watch: false,
        mode: 'development',
        devtool: 'source-map',
        module: {
            rules: [
                {
                    test: /\.m?js$/,
                    exclude: /(node_modules|bower_components)/,
                    use: {
                        loader: 'babel-loader',
                        options: {
                            presets: ['@babel/preset-env']
                        }
                    }
                }
            ]
        }
    },
    {
        entry: ['babel-polyfill', './wwwroot/js/admin/script.js'],
        output: {
            filename: 'admin.js',
            path: path.join(__dirname, './wwwroot/js'),
        },
        watch: false,
        mode: 'development',
        devtool: 'source-map',
        module: {
            rules: [
                {
                    test: /\.m?js$/,
                    exclude: /(node_modules|bower_components)/,
                    use: {
                        loader: 'babel-loader',
                        options: {
                            presets: ['@babel/preset-env']
                        }
                    }
                }
            ]
        }
    }
]