using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001118 RID: 4376
[eiz("SBOF")]
[Serializable]
public sealed class afy : cze, ISerializable
{
	// Token: 0x06005D42 RID: 23874 RVA: 0x0027B1F4 File Offset: 0x002793F4
	private afy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<ka, ka>)A_0.GetValue("SBOF:T", typeof(EntityAspectReference<ka, ka>));
		this.b = A_0.GetBoolean("SBOF:SF");
		this.c = A_0.GetInt32("SBOF:F");
		this.d = A_0.GetBoolean("SBOF:SV");
		this.e = A_0.GetString("SBOF:V");
	}

	// Token: 0x06005D43 RID: 23875 RVA: 0x0027B270 File Offset: 0x00279470
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBOF:T", this.a);
		info.AddValue("SBOF:SF", this.b);
		info.AddValue("SBOF:F", this.c);
		info.AddValue("SBOF:SV", this.d);
		info.AddValue("SBOF:V", this.e);
	}

	// Token: 0x06005D44 RID: 23876 RVA: 0x0027B2DC File Offset: 0x002794DC
	public string b()
	{
		return this.e;
	}

	// Token: 0x06005D45 RID: 23877 RVA: 0x0027B2E4 File Offset: 0x002794E4
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005D46 RID: 23878 RVA: 0x0027B2F0 File Offset: 0x002794F0
	public bool c()
	{
		return this.d;
	}

	// Token: 0x06005D47 RID: 23879 RVA: 0x0027B2F8 File Offset: 0x002794F8
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005D48 RID: 23880 RVA: 0x0027B304 File Offset: 0x00279504
	public bool f()
	{
		return this.b;
	}

	// Token: 0x06005D49 RID: 23881 RVA: 0x0027B30C File Offset: 0x0027950C
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D4A RID: 23882 RVA: 0x0027B318 File Offset: 0x00279518
	public int e()
	{
		return this.c;
	}

	// Token: 0x06005D4B RID: 23883 RVA: 0x0027B320 File Offset: 0x00279520
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005D4C RID: 23884 RVA: 0x0027B32C File Offset: 0x0027952C
	public EntityAspectReference<ka, ka> d()
	{
		return this.a;
	}

	// Token: 0x06005D4D RID: 23885 RVA: 0x0027B334 File Offset: 0x00279534
	public void a(EntityAspectReference<ka, ka> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D4E RID: 23886 RVA: 0x0027B340 File Offset: 0x00279540
	private ka a()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06005D4F RID: 23887 RVA: 0x0027B35C File Offset: 0x0027955C
	public afy()
	{
	}

	// Token: 0x06005D50 RID: 23888 RVA: 0x0027B364 File Offset: 0x00279564
	public afy(ka A_0, bool A_1 = false, int A_2 = 0, bool A_3 = false, string A_4 = null)
	{
		this.a = new EntityAspectReference<ka, ka>(A_0);
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06005D51 RID: 23889 RVA: 0x0027B398 File Offset: 0x00279598
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a() != null)
		{
			if (this.b)
			{
				this.a().b(this.c);
			}
			if (this.d)
			{
				this.a().b(this.e);
			}
		}
	}

	// Token: 0x0400252D RID: 9517
	private new EntityAspectReference<ka, ka> a;

	// Token: 0x0400252E RID: 9518
	private bool b;

	// Token: 0x0400252F RID: 9519
	private int c;

	// Token: 0x04002530 RID: 9520
	private bool d;

	// Token: 0x04002531 RID: 9521
	private string e;
}
