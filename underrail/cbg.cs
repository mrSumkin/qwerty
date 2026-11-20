using System;
using System.Runtime.Serialization;

// Token: 0x02001DE3 RID: 7651
[eiz("CSS")]
[Serializable]
public sealed class cbg : ISerializable
{
	// Token: 0x0600A94B RID: 43339 RVA: 0x003F0878 File Offset: 0x003EEA78
	private cbg(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("CSS:S");
			this.b = A_0.GetBoolean("CSS:I");
			this.c = A_0.GetBoolean("CSS:I1");
			this.d = A_0.GetBoolean("CSS:MB");
			this.e = A_0.GetBoolean("CSS:J");
			this.f = A_0.GetBoolean("CSS:HC");
			this.g = A_0.GetBoolean("CSS:S1");
			if (ell.a() >= 43)
			{
				this.h = A_0.GetBoolean("CSS:F");
			}
			if (ell.a() >= 77)
			{
				this.i = A_0.GetBoolean("CSS:P");
			}
			if (ell.a() >= 278)
			{
				this.j = A_0.GetBoolean("CSS:N");
			}
			if (ell.a() >= 345)
			{
				this.k = A_0.GetBoolean("CSS:T");
			}
			if (ell.a() >= 539)
			{
				this.l = A_0.GetBoolean("CSS:R");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(cbg))
			{
				this.a = A_0.GetBoolean("Stunned");
				this.b = A_0.GetBoolean("Immobilized");
				this.c = A_0.GetBoolean("Incapacitated");
				this.d = A_0.GetBoolean("MindBlocked");
				this.e = A_0.GetBoolean("Jammed");
				this.f = A_0.GetBoolean("HandCuffed");
				this.g = A_0.GetBoolean("Stealthed");
				return;
			}
			this.a = A_0.GetBoolean("CharacterSpecialStates+Stunned");
			this.b = A_0.GetBoolean("CharacterSpecialStates+Immobilized");
			this.c = A_0.GetBoolean("CharacterSpecialStates+Incapacitated");
			this.d = A_0.GetBoolean("CharacterSpecialStates+MindBlocked");
			this.e = A_0.GetBoolean("CharacterSpecialStates+Jammed");
			this.f = A_0.GetBoolean("CharacterSpecialStates+HandCuffed");
			this.g = A_0.GetBoolean("CharacterSpecialStates+Stealthed");
		}
	}

	// Token: 0x0600A94C RID: 43340 RVA: 0x003F0AB0 File Offset: 0x003EECB0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CSS:S", this.a);
		info.AddValue("CSS:I", this.b);
		info.AddValue("CSS:I1", this.c);
		info.AddValue("CSS:MB", this.d);
		info.AddValue("CSS:J", this.e);
		info.AddValue("CSS:HC", this.f);
		info.AddValue("CSS:S1", this.g);
		info.AddValue("CSS:F", this.h);
		info.AddValue("CSS:P", this.i);
		info.AddValue("CSS:N", this.j);
		info.AddValue("CSS:T", this.k);
		info.AddValue("CSS:R", this.l);
	}

	// Token: 0x0600A94D RID: 43341 RVA: 0x003F0B8C File Offset: 0x003EED8C
	public cbg()
	{
	}

	// Token: 0x0600A94E RID: 43342 RVA: 0x003F0B98 File Offset: 0x003EED98
	public cbg b()
	{
		return new cbg
		{
			f = this.f,
			b = this.b,
			c = this.c,
			d = this.d,
			e = this.e,
			f = this.f,
			g = this.g,
			h = this.h,
			i = this.i,
			j = this.j,
			k = this.k,
			l = this.l
		};
	}

	// Token: 0x0600A94F RID: 43343 RVA: 0x003F0C3C File Offset: 0x003EEE3C
	public void a()
	{
		this.a = false;
		this.b = false;
		this.c = false;
		this.d = false;
		this.e = false;
		this.f = false;
		this.g = false;
		this.h = false;
		this.i = false;
		this.j = false;
		this.k = false;
		this.l = false;
	}

	// Token: 0x04003F65 RID: 16229
	public bool a;

	// Token: 0x04003F66 RID: 16230
	public bool b;

	// Token: 0x04003F67 RID: 16231
	public bool c;

	// Token: 0x04003F68 RID: 16232
	public bool d;

	// Token: 0x04003F69 RID: 16233
	public bool e;

	// Token: 0x04003F6A RID: 16234
	public bool f;

	// Token: 0x04003F6B RID: 16235
	public bool g;

	// Token: 0x04003F6C RID: 16236
	public bool h;

	// Token: 0x04003F6D RID: 16237
	public bool i;

	// Token: 0x04003F6E RID: 16238
	public bool j;

	// Token: 0x04003F6F RID: 16239
	public bool k;

	// Token: 0x04003F70 RID: 16240
	public bool l;
}
