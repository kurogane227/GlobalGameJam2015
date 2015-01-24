// Shader created with Shader Forge v1.04 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.04;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:3,bdst:7,culm:0,dpts:2,wrdp:True,dith:2,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:0,x:34584,y:32676,varname:node_0,prsc:2|diff-43-OUT,spec-2664-OUT,normal-4-RGB,amspl-5-OUT;n:type:ShaderForge.SFN_Cubemap,id:1,x:33186,y:32788,ptovrint:False,ptlb:Cubemap,ptin:_Cubemap,varname:_Cubemap,prsc:2,cube:f466cf7415226e046b096197eb7341aa,pvfc:1;n:type:ShaderForge.SFN_Tex2d,id:4,x:34071,y:32833,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:_Normal,prsc:2,tex:80286949e259c2d44876306923857245,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:5,x:34043,y:33005,varname:node_5,prsc:2|A-224-OUT,B-10-OUT;n:type:ShaderForge.SFN_NormalVector,id:6,x:33272,y:33100,prsc:2,pt:False;n:type:ShaderForge.SFN_ComponentMask,id:8,x:33465,y:33100,varname:node_8,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6-OUT;n:type:ShaderForge.SFN_Add,id:10,x:33833,y:33169,varname:node_10,prsc:2|A-12-OUT,B-13-OUT;n:type:ShaderForge.SFN_Vector1,id:11,x:33465,y:33237,varname:node_11,prsc:2,v1:0.4;n:type:ShaderForge.SFN_Multiply,id:12,x:33652,y:33110,varname:node_12,prsc:2|A-8-OUT,B-11-OUT;n:type:ShaderForge.SFN_OneMinus,id:13,x:33652,y:33237,varname:node_13,prsc:2|IN-11-OUT;n:type:ShaderForge.SFN_Vector1,id:214,x:33186,y:32943,varname:node_214,prsc:2,v1:8;n:type:ShaderForge.SFN_Multiply,id:215,x:33382,y:32826,varname:node_215,prsc:2|A-1-RGB,B-1-A,C-214-OUT;n:type:ShaderForge.SFN_Fresnel,id:223,x:33506,y:32282,varname:node_223,prsc:2|EXP-1080-OUT;n:type:ShaderForge.SFN_Lerp,id:224,x:33732,y:32881,varname:node_224,prsc:2|A-225-OUT,B-215-OUT,T-223-OUT;n:type:ShaderForge.SFN_Multiply,id:225,x:33556,y:32712,varname:node_225,prsc:2|A-226-OUT,B-215-OUT;n:type:ShaderForge.SFN_Vector1,id:226,x:33360,y:32712,varname:node_226,prsc:2,v1:0.7;n:type:ShaderForge.SFN_ConstantLerp,id:286,x:33663,y:32175,varname:node_286,prsc:2,a:0.2,b:0|IN-223-OUT;n:type:ShaderForge.SFN_Slider,id:1080,x:33155,y:32386,ptovrint:False,ptlb:Fresnel Exponent,ptin:_FresnelExponent,varname:_FresnelExponent,prsc:2,min:1,cur:2.526316,max:8;n:type:ShaderForge.SFN_Add,id:7927,x:33973,y:32259,varname:node_7927,prsc:2|A-3958-OUT,B-4163-RGB;n:type:ShaderForge.SFN_Tex2d,id:4163,x:33607,y:32478,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_4163,prsc:2,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:43,x:34122,y:32378,varname:node_43,prsc:2|A-7927-OUT,B-1251-RGB;n:type:ShaderForge.SFN_Color,id:1251,x:33894,y:32555,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1251,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Add,id:2664,x:34315,y:32668,varname:node_2664,prsc:2|A-43-OUT,B-1239-OUT;n:type:ShaderForge.SFN_Vector3,id:1239,x:34126,y:32668,varname:node_1239,prsc:2,v1:-0.27,v2:0.08,v3:0.08;n:type:ShaderForge.SFN_Multiply,id:3958,x:33824,y:32101,varname:node_3958,prsc:2|A-286-OUT,B-4163-RGB;proporder:1251-4163-4-1-1080;pass:END;sub:END;*/

Shader "GGJ/MetalShaderPalette" {
    Properties {
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _MainTex ("MainTex", 2D) = "white" {}
        _Normal ("Normal", 2D) = "bump" {}
        _Cubemap ("Cubemap", Cube) = "_Skybox" {}
        _FresnelExponent ("Fresnel Exponent", Range(1, 8)) = 2.526316
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles xbox360 ps3 flash 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform samplerCUBE _Cubemap;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _FresnelExponent;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 binormalDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.binormalDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.binormalDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float4 _Cubemap_var = texCUBE(_Cubemap,viewReflectDirection);
                float3 node_215 = (_Cubemap_var.rgb*_Cubemap_var.a*8.0);
                float node_223 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExponent);
                float node_11 = 0.4;
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_43 = (((lerp(0.2,0,node_223)*_MainTex_var.rgb)+_MainTex_var.rgb)*_Color.rgb);
                float3 specularColor = (node_43+float3(-0.27,0.08,0.08));
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow);
                float3 indirectSpecular = (0 + (lerp((0.7*node_215),node_215,node_223)*((i.normalDir.g*node_11)+(1.0 - node_11))));
                float3 specular = (directSpecular + indirectSpecular) * specularColor;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 indirectDiffuse = float3(0,0,0);
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * node_43;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ForwardAdd"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            Fog { Color (0,0,0,0) }
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma exclude_renderers gles xbox360 ps3 flash 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _FresnelExponent;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 binormalDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.binormalDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.binormalDir, i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal)));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_223 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelExponent);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_43 = (((lerp(0.2,0,node_223)*_MainTex_var.rgb)+_MainTex_var.rgb)*_Color.rgb);
                float3 specularColor = (node_43+float3(-0.27,0.08,0.08));
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow);
                float3 specular = directSpecular * specularColor;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuse = directDiffuse * node_43;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
