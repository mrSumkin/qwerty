using System;
using System.Runtime.Serialization;

// Token: 0x020006AD RID: 1709
[eiz("RFIP")]
[Serializable]
public sealed class dc5 : ap
{
	// Token: 0x06002C47 RID: 11335 RVA: 0x000FDB08 File Offset: 0x000FBD08
	private dc5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("RFIP:F");
		this.b = A_0.GetInt32("RFIP:T");
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x000FDB34 File Offset: 0x000FBD34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RFIP:F", this.a);
		info.AddValue("RFIP:T", this.b);
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x000FDB60 File Offset: 0x000FBD60
	public int a()
	{
		return this.a;
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x000FDB68 File Offset: 0x000FBD68
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x000FDB74 File Offset: 0x000FBD74
	public int b()
	{
		return this.b;
	}

	// Token: 0x06002C4C RID: 11340 RVA: 0x000FDB7C File Offset: 0x000FBD7C
	public void b(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002C4D RID: 11341 RVA: 0x000FDB88 File Offset: 0x000FBD88
	public dc5()
	{
	}

	// Token: 0x06002C4E RID: 11342 RVA: 0x000FDB90 File Offset: 0x000FBD90
	public override string ToString()
	{
		return string.Format("{0}: {1}-{2}", base.c(), this.a, this.b);
	}

	// Token: 0x06002C4F RID: 11343 RVA: 0x000FDBB8 File Offset: 0x000FBDB8
	public override object j1(Random A_0)
	{
		return (A_0 ?? new Random()).Next(this.a, this.b + 1);
	}

	// Token: 0x04001928 RID: 6440
	private new int a;

	// Token: 0x04001929 RID: 6441
	private int b;
}
