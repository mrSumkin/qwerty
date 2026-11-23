using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001098 RID: 4248
[eiz("SCOM")]
[Serializable]
public sealed class doh : cze, ISerializable
{
	// Token: 0x0600590A RID: 22794 RVA: 0x00268DA0 File Offset: 0x00266FA0
	private doh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SCOM:WN");
		this.b = (Guid?)A_0.GetValue("SCOM:TID", typeof(Guid?));
		this.c = (bvl)A_0.GetValue("SCOM:CH", typeof(bvl));
	}

	// Token: 0x0600590B RID: 22795 RVA: 0x00268E10 File Offset: 0x00267010
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCOM:WN", this.a);
		info.AddValue("SCOM:TID", this.b);
		info.AddValue("SCOM:CH", this.c);
	}

	// Token: 0x0600590C RID: 22796 RVA: 0x00268E64 File Offset: 0x00267064
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600590D RID: 22797 RVA: 0x00268E6C File Offset: 0x0026706C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x00268E78 File Offset: 0x00267078
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x00268E80 File Offset: 0x00267080
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x00268E8C File Offset: 0x0026708C
	public bvl a()
	{
		return this.c;
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x00268E94 File Offset: 0x00267094
	public void a(bvl A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x00268EA0 File Offset: 0x002670A0
	public doh()
	{
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x00268EB0 File Offset: 0x002670B0
	public doh(string A_0, Guid? A_1, bvl A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x00268ED4 File Offset: 0x002670D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow.aqu() != null && c5x != null)
		{
			b0b b0b = null;
			if (this.b != null)
			{
				b0b = (new ar7(this.b.Value, A_0.Area).ao() as c5x);
			}
			else
			{
				switch (this.c)
				{
				case bvl.a:
					if (!(A_0 as c5x).IsPlayer)
					{
						b0b = A_0;
					}
					else
					{
						b0b = A_1;
					}
					break;
				case bvl.b:
					b0b = A_0;
					break;
				case bvl.c:
					b0b = A_1;
					break;
				case bvl.d:
					if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
					{
						b0b = serviceOrThrow.aqu().v().b();
					}
					break;
				}
			}
			if (b0b != null)
			{
				bm6 aspect = b0b.GetAspect<bm6>();
				if (aspect != null)
				{
					if (string.IsNullOrEmpty(this.a))
					{
						this.a = "LeaveMap";
					}
					aspect.y6()[ddq.ay] = new bt4(this.a);
					aspect.y6()[ddq.bg] = true;
					aspect.y6().RemoveProperty(ddq.k);
				}
			}
		}
	}

	// Token: 0x040023D7 RID: 9175
	private new string a;

	// Token: 0x040023D8 RID: 9176
	private Guid? b;

	// Token: 0x040023D9 RID: 9177
	private bvl c = bvl.c;
}
