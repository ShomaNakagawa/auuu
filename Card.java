/**
 * 
 */
package cardgame2;

/**
 * @author 
 *
 */
public class Card {
 private char suit;	
 private int number;
	public Card(char s,int n) {
	this.suit=s;
	this.number=n;
	}
	public char getSuit() {
		return this.suit;
		}
	public int getNumber() {
		return this.number;
	}
	public String toString() {
		char a='a';
		if(this.number==10) {
			a='T';
		}else if(this.number==11) {
			a='J';
		}else if(this.number==12) {
			a='Q';
		}else if(this.number==13) {
			a='K';
		}else if(this.number==1) {
			a='A';
		}
		if(this.number>=2&&this.number<=9) {
		return this.suit+"-"+this.number;
		}else {
			return this.suit+"-"+a;
		}
	}
}
