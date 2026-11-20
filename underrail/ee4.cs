using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020001FA RID: 506
[eiz("NP")]
[Serializable]
public struct ee4 : ISerializable
{
	// Token: 0x06000E6A RID: 3690 RVA: 0x0003A6CC File Offset: 0x000388CC
	private ee4(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Point)A_0.GetValue("NP:C", typeof(Point));
		if (ell.b() >= 16)
		{
			this.b = A_0.GetInt32("NP:A");
			return;
		}
		this.b = 0;
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x0003A720 File Offset: 0x00038920
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("NP:C", this.a);
		info.AddValue("NP:A", this.b);
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x0003A74C File Offset: 0x0003894C
	public static bool b(ee4 A_0, ee4 A_1)
	{
		return A_0.a(A_1);
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x0003A758 File Offset: 0x00038958
	public static bool a(ee4 A_0, ee4 A_1)
	{
		return !A_0.a(A_1);
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x0003A768 File Offset: 0x00038968
	public ee4(int A_0, Point A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x0003A778 File Offset: 0x00038978
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode();
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0003A79C File Offset: 0x0003899C
	public override bool Equals(object obj)
	{
		ee4 ee = (ee4)obj;
		return this.a.X.Equals(ee.a.X) && this.a.Y.Equals(ee.a.Y) && this.b.Equals(ee.b);
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x0003A804 File Offset: 0x00038A04
	public bool a(ee4 A_0)
	{
		return this.a == A_0.a && this.b == A_0.b;
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x0003A830 File Offset: 0x00038A30
	public override string ToString()
	{
		Point point = this.a;
		return point.ToString() + "(" + this.b.ToString() + ")";
	}

	// Token: 0x04000885 RID: 2181
	public Point a;

	// Token: 0x04000886 RID: 2182
	public int b;
}
