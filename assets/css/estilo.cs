:root{
    --light: #f5f5f5;
    --dark: #212121;
}

* {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

body{
    background-color: var(--light);
    color: var(--dark);
}

.container{
    width: 100vw;
    height: 100vh;

    display: flex;
    justify-content: center;
    align-items: center;
}

.content{
    width: 250px;

    display: flex;
    flex-direction: column;
    align-items: center;

    margin:50px;
}

.btn{
    margin-top: 32px;
    width: 160px;
    padding: 8px;
    border-radius: 8px;
    border: 2px solid var(--dark);
    background-color: var(--light);
    font-weight: bold;
    cursor: pointer;
}

.dark-theme{
    background-color: var(--dark);
    color: var(--light);
}

.dark-theme .btn{
    border: 2px solid var(--light);
    background-color: var(--dark);
    color: var(--light);
}
