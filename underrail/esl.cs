using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200118A RID: 4490
[eiz("CD")]
[Serializable]
public sealed class esl : ISerializable
{
	// Token: 0x06005FDF RID: 24543 RVA: 0x0029C178 File Offset: 0x0029A378
	private esl(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.b = (c5x)A_0.GetValue("CD:E", typeof(c5x));
			this.c = (amc)A_0.GetValue("CD:C", typeof(amc));
			this.d = (bm6)A_0.GetValue("CD:I", typeof(bm6));
			this.e = (c9y)A_0.GetValue("CD:DL", typeof(c9y));
			if (ell.a() >= 27)
			{
				this.f = (ale)A_0.GetValue("CD:T", typeof(ale));
				return;
			}
			this.f = new ale(this.b);
			return;
		}
		else
		{
			if (base.GetType() == typeof(esl))
			{
				this.b = (c5x)A_0.GetValue("_Entity", typeof(c5x));
				this.c = (amc)A_0.GetValue("_Character", typeof(amc));
				this.d = (bm6)A_0.GetValue("_Intelligence", typeof(bm6));
				this.e = (c9y)A_0.GetValue("_DynamicLoot", typeof(c9y));
				return;
			}
			this.b = (c5x)A_0.GetValue("CharacterDefinition+_Entity", typeof(c5x));
			this.c = (amc)A_0.GetValue("CharacterDefinition+_Character", typeof(amc));
			this.d = (bm6)A_0.GetValue("CharacterDefinition+_Intelligence", typeof(bm6));
			this.e = (c9y)A_0.GetValue("CharacterDefinition+_DynamicLoot", typeof(c9y));
			return;
		}
	}

	// Token: 0x06005FE0 RID: 24544 RVA: 0x0029C370 File Offset: 0x0029A570
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CD:E", this.b);
		info.AddValue("CD:C", this.c);
		info.AddValue("CD:I", this.d);
		info.AddValue("CD:DL", this.e);
		info.AddValue("CD:T", this.f);
	}

	// Token: 0x06005FE1 RID: 24545 RVA: 0x0029C3D4 File Offset: 0x0029A5D4
	public amc d()
	{
		return this.c;
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x0029C3DC File Offset: 0x0029A5DC
	public void a(amc A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005FE3 RID: 24547 RVA: 0x0029C3E8 File Offset: 0x0029A5E8
	public c9y b()
	{
		return this.e;
	}

	// Token: 0x06005FE4 RID: 24548 RVA: 0x0029C3F0 File Offset: 0x0029A5F0
	public void a(c9y A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005FE5 RID: 24549 RVA: 0x0029C3FC File Offset: 0x0029A5FC
	public bm6 c()
	{
		return this.d;
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x0029C404 File Offset: 0x0029A604
	public void a(bm6 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x0029C410 File Offset: 0x0029A610
	public ale a()
	{
		return this.f;
	}

	// Token: 0x06005FE8 RID: 24552 RVA: 0x0029C418 File Offset: 0x0029A618
	public void a(ale A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x0029C424 File Offset: 0x0029A624
	public esl()
	{
		this.b = new c5x();
		this.c = new amc(this.b, new StandAloneProvider<efk>(new efk()));
		this.d = new bm6(this.b);
		this.f = new ale(this.b);
		this.e = new c9y();
	}

	// Token: 0x04002836 RID: 10294
	public const string a = "char";

	// Token: 0x04002837 RID: 10295
	private c5x b;

	// Token: 0x04002838 RID: 10296
	private amc c;

	// Token: 0x04002839 RID: 10297
	private bm6 d;

	// Token: 0x0400283A RID: 10298
	private c9y e;

	// Token: 0x0400283B RID: 10299
	private ale f;
}
