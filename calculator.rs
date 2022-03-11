use std::env::{args, Args};

fn main() {
    let mut args: Args = args();

    let first = args.nth(1).unwrap();
    let operator = args.nth(0).unwrap().chars().next().unwrap();
    let second = args.nth(0).unwrap();

  //let first_number: f32 = first.parse().unwrap();
  //let second_number: f32 = second.parse().unwrap();
	let first_number = first.parse::<f32>().unwrap();
	let second_number = second.parse::<f32>().unwrap();

	let result = operate(operator, first_number, second_number);

    println!("{:?}", output(first_number, operator, second_number, result));
}

fn operate(operator: char, first_number: f32, second_number: f32) -> f32{
    match operator {
        '+' => first_number + second_number,
        '-' => first_number - second_number,
        '/' => first_number / second_number,
        '*' | 'x' | 'X' => first_number * second_number,
        _ => 0.0
//        _ => panic!("Invalid operator used.")
    }
}

fn output(first_number: f32, operator: char, second_number: f32, result: f32) -> String {
    format!("{} {} {} = {}", first_number, operator, second_number, result)
}

    #[test]
    fn add() {
        assert_eq!(2_f32, operate('+', 1_f32, 1_f32) );
    }
    #[test]
    fn substruct() {
        assert_eq!(2_f32, operate('-', 4_f32, 2_f32) );
    }
    #[test]
    fn multiply() {
        assert_eq!(4_f32, operate('*', 2_f32, 2_f32) );
        assert_eq!(4_f32, operate('x', 2_f32, 2_f32) );
        assert_eq!(4_f32, operate('X', 2_f32, 2_f32) );
    }
    #[test]
    fn divide() {
        assert_eq!(2_f32, operate('/', 4_f32, 2_f32) );
    }
    #[test]
    fn it_wont_work() {
        assert_ne!(2_f32, operate('a', 4_f32, 2_f32) );
    }
