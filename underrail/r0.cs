using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020001F9 RID: 505
[eiz("NP2")]
[Serializable]
public struct r0 : ISerializable
{
	// Token: 0x06000E61 RID: 3681 RVA: 0x0003A590 File Offset: 0x00038790
	private r0(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Vector2)A_0.GetValue("NP2:C", typeof(Vector2));
		this.b = A_0.GetInt32("NP2:A");
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0003A5C4 File Offset: 0x000387C4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("NP2:C", this.a);
		info.AddValue("NP2:A", this.b);
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0003A5F0 File Offset: 0x000387F0
	public static bool b(r0 A_0, r0 A_1)
	{
		return A_0.a(A_1);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0003A5FC File Offset: 0x000387FC
	public static bool a(r0 A_0, r0 A_1)
	{
		return !A_0.a(A_1);
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x0003A60C File Offset: 0x0003880C
	public r0(int A_0, Vector2 A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x0003A61C File Offset: 0x0003881C
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode();
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x0003A640 File Offset: 0x00038840
	public override bool Equals(object obj)
	{
		bool result = false;
		if (obj is r0)
		{
			result = this.a((r0)obj);
		}
		return result;
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0003A668 File Offset: 0x00038868
	public bool a(r0 A_0)
	{
		return this.a == A_0.a && this.b == A_0.b;
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x0003A690 File Offset: 0x00038890
	public override string ToString()
	{
		Vector2 vector = this.a;
		return vector.ToString() + "(" + this.b.ToString() + ")";
	}

	// Token: 0x04000883 RID: 2179
	public Vector2 a;

	// Token: 0x04000884 RID: 2180
	public int b;
}
