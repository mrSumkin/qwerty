using System;
using System.Runtime.Serialization;

namespace Ouroboros.Common.Data
{
	// Token: 0x0200221A RID: 8730
	[eiz("ERR")]
	[Serializable]
	public sealed class ExternalResolverReference<T> : TypedObjectReference<T>, ISerializable where T : class
	{
		// Token: 0x0600CAAE RID: 51886 RVA: 0x0047CAC4 File Offset: 0x0047ACC4
		public string a()
		{
			return this.b;
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x0047CACC File Offset: 0x0047ACCC
		public void a(string A_0)
		{
			this.b = A_0;
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x0047CAD8 File Offset: 0x0047ACD8
		public ExternalResolverReference(IResolver<T> A_0)
		{
			czh.a(A_0, "resolver");
			this.a = A_0;
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x0047CAF4 File Offset: 0x0047ACF4
		private ExternalResolverReference(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			if (ell.b() != 0)
			{
				this.a = (IResolver<T>)A_0.GetValue("ERR:R", typeof(IResolver<T>));
				this.b = A_0.GetString("ERR:RC");
				return;
			}
			if (base.GetType() == typeof(TypedObjectReference<T>))
			{
				this.a = (IResolver<T>)A_0.GetValue("_Resolver", typeof(IResolver<T>));
				this.b = A_0.GetString("_ReferenceContainer");
				return;
			}
			this.a = (IResolver<T>)A_0.GetValue("ExternalResolverReference`1+_Resolver", typeof(IResolver<T>));
			this.b = A_0.GetString("ExternalResolverReference`1+_ReferenceContainer");
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x0047CBC4 File Offset: 0x0047ADC4
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ERR:R", this.a);
			info.AddValue("ERR:RC", this.b);
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x0047CBF0 File Offset: 0x0047ADF0
		protected override T h4()
		{
			return this.a.a(this);
		}

		// Token: 0x04004A23 RID: 18979
		private IResolver<T> a;

		// Token: 0x04004A24 RID: 18980
		private string b;
	}
}
