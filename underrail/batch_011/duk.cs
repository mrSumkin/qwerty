using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001447 RID: 5191
[eiz("PSGCOHC")]
[Serializable]
public sealed class duk : enp, ISerializable
{
	// Token: 0x060074B4 RID: 29876 RVA: 0x00317BA0 File Offset: 0x00315DA0
	private duk(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<string>("PSGCOHC:C", ref this.a, A_0);
		if (ell.a() >= 515)
		{
			this.b = (A_0.GetValue("PSGCOHC:I", typeof(enp)) as enp);
		}
	}

	// Token: 0x060074B5 RID: 29877 RVA: 0x00317BF4 File Offset: 0x00315DF4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<string>("PSGCOHC:C", this.a, info);
		info.AddValue("PSGCOHC:I", this.b);
	}

	// Token: 0x060074B6 RID: 29878 RVA: 0x00317C18 File Offset: 0x00315E18
	public duk(List<string> A_0, enp A_1 = null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060074B7 RID: 29879 RVA: 0x00317C34 File Offset: 0x00315E34
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (this.a != null && A_2 != null && A_2.b && A_1 != null && A_1.a8() != null && A_1.a8().Area != null && A_1.a8().Zone != null)
		{
			c5x c5x = vq.a("Object\\Meta\\SoundSpot", A_1.a8().Zone, new bt4(A_1.a8().Area.y8(), A_1.a8().Location), false);
			if (c5x != null)
			{
				do6 @do = new do6(c5x);
				@do.a(true);
				do6 aspect = @do;
				c5x.SetAspect<do6>(aspect);
				cm aspect2 = new cm(c5x, 5000, false);
				c5x.SetAspect<cm>(aspect2);
				foreach (string a_ in this.a)
				{
					c5x.c().a(a_);
				}
			}
		}
		if (this.b != null)
		{
			this.b.af(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x04002FAC RID: 12204
	private List<string> a;

	// Token: 0x04002FAD RID: 12205
	private enp b;
}
