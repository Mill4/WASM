export function initialize(matrix, clearBit, length) {
    for (let i = 0; i < length; i++) {
        for (let j = 0; j < length; j++) {
            matrix[i * length + j] =
                (Math.floor(Math.random() * (1001 - 1)) + 1001) * clearBit;
        }
    }
}

export function ijk(matrixA, matrixB, matrixC, length) {
    for (let i = 0; i < length; i++) {
        for (let j = 0; j < length; j++) {
            for (let k = 0; k < length; k++) {
                matrixC[i * length + j] +=
                    matrixA[i * length + k] * matrixB[j * length + k];
            }
        }
    }
}

export function kji(matrixA, matrixB, matrixC, length) {
    for (let k = 0; k < length; k++) {
        for (let j = 0; j < length; j++) {
            for (let i = 0; i < length; i++) {
                matrixC[i * length + j] +=
                    matrixA[i * length + k] * matrixB[j * length + k];
            }
        }
    }
}

export function bmm(matrixA, matrixB, matrixC, length, blockSize) {
    let block = blockSize * (length / blockSize);
    let sum;
    for (let kk = 0; kk < block; kk += blockSize) {
        for (let jj = 0; jj < block; jj += blockSize) {
            for (let i = 0; i < length; i++) {
                for (let j = jj; j < jj + blockSize; j++) {
                    sum = matrixC[i * length + j];
                    for (let k = kk; k < kk + blockSize; k++) {
                        sum +=
                            matrixA[i * length + j] * matrixB[i * length + j];
                    }
                    matrixC[i * length + j] = sum;
                }
            }
        }
    }
}
