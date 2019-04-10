// Trenches VideoGame Roughdraft...

// Player Movements: Move x amount of units, x-axis
public Rigidbody Player;
public float speed;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// Updates per frame
void Update() {
 if(Input.GetKey(KeyCode.RightArrow)) {
 	Player.AddForce(speed * Time.deltaTime, 0, 0);
 	As.Play();
 	Debug.Log(PLAYER IS MOVING RIGHT);
 }
 if(Input.GetKey(KeyCode.LeftArrow)) {
 	Player.AddForce(-speed * Time.deltaTime, 0, 0);
 	As.Play();
 	Debug.Log(PLAYER IS MOVING RIGHT);
 }
}


// Player Movements: Rotate object +- on y axis
public Rigidbody Player;
public float speed;
public Vector3;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// Updates per frame
void Update() {
if(Input.GetKey(KeyCode.UpArrow)) {
 	Player.Rotate(0, speed * Time.deltaTime, 0);
 	As.Play();
 	Debug.Log(PLAYER IS ROTATING UP);
 }
if(Input.GetKey(KeyCode.DownArrow)) {
 	Player.Rotate(0, -speed * Time.deltaTime, 0);
 	As.Play();
 	Debug.Log(PLAYER IS ROTATING DOWN);
 }
}


// Player Movements: Object animation per frame
public Rigidbody Player;
public float speed;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// Updates per frame
void Update() {
	for(i = 0, i < .Length, i++) {
      // Activate player animation
		As.Play();
		Debug.Log(ANIMATION ACTIVE);
	}
}


// Player Reaction: End Game if player is destroyed
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.CompareTag(EnemyBeam)) {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       As.Play();
       Debug.Log(END GAME);
	}
}


// Object Action: On input instantiate projectile 
public Rigidbody Beam;
public float speed;
public Rigidbody Barrel;
public float seconds = 2f;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// Updates per frame
void Update() {
if(Input.GetKey(KeyCode.Space)) {
 	Instantiate(Beam, seconds);
 	Beam.AddForce(0, 0, speed * Time.deltaTime);
 	As.Play();
 	Debug.Log(BEAM HAS FIRED);
 }
}


// Object Action(Extra side turrets): Eject projectiles on trigger
// Turret1
public Rigidbody Beam;
public Rigidbody Barrel;
public float speed;
public float speed2;
public Vector3;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.Compare.GameTag(Enemy)) {
       Instantiate(Beam, 3f);
       Beam.AddForce(0, speed * Time.deltaTime, speed2 * Time.deltaTime)
       Debug.Log(TURRET1 WAS TRIGGERED / FIRED);
       As.Play();
       Update();
	}
}


// Object Action(Extra side turrets): Eject projectiles on trigger
// Turret2
public Rigidbody Beam;
public Rigidbody Barrel;
public float speed;
public float speed2;
public Vector3;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.Compare.GameTag(Enemy)) {
       Instantiate(Beam, 3f);
       Beam.AddForce(0, speed * Time.deltaTime, speed2 * Time.deltaTime)
       Debug.Log(TURRET1 WAS TRIGGERED / FIRED);
       As.Play();
       Update();
	}
}


// Object Action: OnTrigger EnemyBot destoy
public Rigidbody EnemyBot; 
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.CompareTag(TurretBeam)) {
       destoy(EnemyBot);
       // Run animation
       As.Play();
       Debug.Log(ENEMYBOT DESTROYED BY PROJECTILE);
	}
}


// EnemyBot Movement: Acceleration on z axis
public Rigidbody EnemyBot; 
public float speed;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// Updates per Frame
void Update() {
	EnemyBot.AddForce(0,0, speed * Time.deltaTime);
	As.Play();
}


// Environment Functions: End Game
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.CompareTag(EnemyBot)) {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       As.Play();
       Debug.Log(END GAME);
	}
}


// EnemyBot Actions: Ontrigger instantiate projectile
public Rigidbody Beam;
public Rigidbody Barrel;
public float speed;
public float speed2;
public Vector3;
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.Compare.GameTag(Player)) {
       Instantiate(Beam, 3f);
       Beam.AddForce(0, speed * Time.deltaTime, speed2 * Time.deltaTime)
       Debug.Log(ENEMY FIRED WEAPON);
       As.Play();
       Update();
	}
}


// Environment Functions: Scene Change 1
public AudioClip AU;
public AudioSource AS;
// Start audio
void Start() {
 As.clip = Au;
}
// OnTrigger Event
void OnTriggerEnter(collider, other) {
	if(other.CompareTag(Player)) {
      SceneManager.LoadScene(#);
       As.Play();
       Debug.Log(SCENE CHANGE 1);
	}
}