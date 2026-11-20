using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001074 RID: 4212
[eiz("DLJ")]
[Serializable]
public sealed class dub : cze, ISerializable
{
	// Token: 0x060057C3 RID: 22467 RVA: 0x0026383C File Offset: 0x00261A3C
	private dub(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("DLJ:I", typeof(Guid?));
		this.c = A_0.GetString("DLJ:A");
		this.a = A_0.GetString("DLJ:N");
	}

	// Token: 0x060057C4 RID: 22468 RVA: 0x00263894 File Offset: 0x00261A94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DLJ:I", this.b);
		info.AddValue("DLJ:A", this.c);
		info.AddValue("DLJ:N", this.a);
	}

	// Token: 0x060057C5 RID: 22469 RVA: 0x002638E4 File Offset: 0x00261AE4
	public string b()
	{
		return this.a;
	}

	// Token: 0x060057C6 RID: 22470 RVA: 0x002638EC File Offset: 0x00261AEC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057C7 RID: 22471 RVA: 0x002638F8 File Offset: 0x00261AF8
	public string a()
	{
		return this.c;
	}

	// Token: 0x060057C8 RID: 22472 RVA: 0x00263900 File Offset: 0x00261B00
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060057C9 RID: 22473 RVA: 0x0026390C File Offset: 0x00261B0C
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x060057CA RID: 22474 RVA: 0x00263914 File Offset: 0x00261B14
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060057CB RID: 22475 RVA: 0x00263920 File Offset: 0x00261B20
	public dub()
	{
	}

	// Token: 0x060057CC RID: 22476 RVA: 0x00263928 File Offset: 0x00261B28
	public dub(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057CD RID: 22477 RVA: 0x00263938 File Offset: 0x00261B38
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				aud = A_1.Zone.n(this.c);
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(c5x.RaysEmitters), new Func<bsf, bool>(this.a)));
			if (bsf != null)
			{
				bsf.ig();
			}
		}
	}

	// Token: 0x060057CE RID: 22478 RVA: 0x002639EC File Offset: 0x00261BEC
	[CompilerGenerated]
	private bool a(bsf A_0)
	{
		return A_0.Definition != null && A_0.Definition.Name == this.a;
	}

	// Token: 0x0400237B RID: 9083
	private new string a;

	// Token: 0x0400237C RID: 9084
	private Guid? b;

	// Token: 0x0400237D RID: 9085
	private string c;
}
