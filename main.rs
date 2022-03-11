#![allow(unused)]
fn main() {
    print_border(6, 5);
}
fn print_border(x: i32, y: i32) {
    let range = std::ops::Range {
        start: 1,
        end: y + 1,
    };
    for i in range {
        print!("+");
    }
    println!("");
    let range = std::ops::Range { start: 1, end: x };
    for i in range {
        let col = 0;
        let mut col_index: u32 = 0;
        let range = std::ops::Range { start: 1, end: x };
        for i in range {
            match col_index {
                0 => print!("+"),
                1..=3 => print!(" "),
                x => print!("+")
            }
            col_index += 1;
        }
        println!("");
    }
    let range = std::ops::Range {
        start: 1,
        end: y + 1,
    };
    for i in range {
        print!("+");
    }
    println!("");
}
