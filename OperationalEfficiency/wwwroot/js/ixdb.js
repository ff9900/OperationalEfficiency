// データベースの作成
var db = new Dexie("AppDatabase");

// オブジェクトストア（テーブル）の作成
db.version(1).stores({
    tasks: "++id, name, limitDate, isDone, deleted",
    projects: "++id, name, limitDate, isDone, deleted"
});

function putTask(value) {
    await db.tasks.put(value);
}

function getTask(key) {
    return db.tasks.get(key);
}

function getAllTasks() {
    return await db.tasks.toArray();
}


