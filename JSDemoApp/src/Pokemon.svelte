<script lang="ts">
    import { initialize, ijk, kji, bmm } from "./calculate";

    const lengthArray = [1, 64, 128, 256, 512, 1024];
    const maxLength = 1024 * 1024;
    const blockSize = 32;
    let bufferA = new ArrayBuffer(maxLength);
    let bufferB = new ArrayBuffer(maxLength);
    let bufferC = new ArrayBuffer(maxLength);
    let matrixA = new Float64Array(bufferA);
    let matrixB = new Float64Array(bufferB);
    let matrixC = new Float64Array(bufferC);

    lengthArray.forEach((length) => {
        initialize(matrixA, 1, length);
        initialize(matrixB, 1, length);
        initialize(matrixC, 0, length);

        console.time(length + ", ijk");
        ijk(matrixA, matrixB, matrixC, length);
        console.timeEnd(length + ", ijk");

        initialize(matrixC, 0, length);
        console.time(length + ", kji");
        kji(matrixA, matrixB, matrixC, length);
        console.timeEnd(length + ", kji");

        initialize(matrixC, 0, length);
        console.time(length + ", bmm");
        bmm(matrixA, matrixB, matrixC, length, blockSize);
        console.timeEnd(length + ", bmm");
    });
</script>

<main>Vanilla JS</main>
